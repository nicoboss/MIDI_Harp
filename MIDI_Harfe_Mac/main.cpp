//*****************************************//
//  MIDI_Harfe
//  von Nico Bosshard (c)2016
//
//  MIDI Harfen Empfänger für MacOSX.
//
//*****************************************//

#include <iostream>
#include <math.h>
#include <cstdlib> //ermöglicht system()
#include "RtMidi.h"
#include <fcntl.h>
#include <fstream>
#include <termios.h>
#include <string>
#include <sstream>
#include <vector>
#include <Carbon/Carbon.h>

#include "CoreFoundation/CoreFoundation.h"



using namespace std;

//#define USB_SERIAL_PORT "/dev/tty.usbserial-0000103D" // (OSX Power Book)
//#define USB_SERIAL_PORT  "/dev/cu.usbserial-3B1" // (OSX Mac Book)
//#define USB_SERIAL_PORT "/dev/tty.usbserial-0000103D" // (Linux Ubuntu Mac Book)
//#define USB_SERIAL_PORT "/dev/tty.usbserial-0000103D"
#define USB_SERIAL_PORT "/dev/cu.usbserial-FTUPO2WD"

int port_fd;

int init_serial_input(char * port);
int read_serial_int(int fd);

bool ConfigFile_Read(string configFile);
void ConfigFile_Create(string configFile);

bool Update_Funktion(void);

bool Onlineaktivierung(void);
void GetHash(void);
void get_platform_uuid(char * buf, int bufSize);




// Platform-dependent sleep routines.
#if defined(__WINDOWS_MM__)
#include <windows.h>
#define SLEEP( milliseconds ) Sleep( (DWORD) milliseconds )
#else // Unix variants
#include <unistd.h>
#define SLEEP( milliseconds ) usleep( (unsigned long) (milliseconds * 1000.0) )
#endif

// This function should be embedded in a try/catch block in case of
// an exception.  It offers the user a choice of MIDI ports to open.
// It returns false if there are no ports available.
bool chooseMidiPort( RtMidiOut *rtmidi );
RtMidiOut *midiout = 0;

vector< vector<int> > Config_Note;

vector<string> Noten_Name {
   "C", "D", "E", "F", "G", "A", "H",
   "c", "d", "e", "f", "g", "a", "h",
   "c'", "d'", "e'", "f'", "g'", "a'", "h'",
   "c''", "d''", "e''", "f''", "g''", "a''", "h''",
   "c'''", "d'''", "e'''", "f'''", "g'''", "a'''", "h'''",
   "c''''"};

vector<unsigned char> Noten_Nr {
   36, 38, 40, 41, 43, 45, 47,
   48, 50, 52, 53, 55, 57, 59,
   60, 62, 64, 65, 67, 69, 71,
   72, 74, 76, 77, 79, 81, 83,
   84, 86, 88, 89, 91, 93, 95,
   96};


char path[PATH_MAX];


#define _Start_ 0;
#define _Stop_ 1;
#define _Transpose_ 2;
#define _Volume_ 3;
#define _Mute_ 4;


string Config_Path;
unsigned char Config_Instrument=0;
bool Config_Volume_ignore=false;
signed char Config_Volume_steps=false;
signed char Config_Volume_min=15;
signed char Config_Volume_max=250;
signed char Config_Master_Transpose=0;
bool Config_use_Virtual_Port=true;
string Config_Portnamen="MIDI_Harfe";
unsigned char Config_PortNr=0;
vector<signed char> Config_Transpose;

vector<bool> Note_Play { 0,0,0,0,0,0,0, 0,0,0,0,0,0,0, 0,0,0,0,0,0,0, 0,0,0,0,0,0,0, 0,0,0,0,0,0,0, 0 };



char code_ascii;


#include <sys/types.h>
#include <sys/socket.h>
#include <ifaddrs.h>
#include <netinet/in.h>
#include <net/if.h>
#ifdef __linux__
#    include <sys/ioctl.h>
#    include <netinet/in.h>
#    include <unistd.h>
#    include <string.h>

//    Match Linux to FreeBSD
#    define AF_LINK AF_PACKET
#else
#    include <net/if_dl.h>
#endif

#include <stdio.h>
#include <stdlib.h>

const sockaddr_in* castToIP4(const sockaddr* addr) {
   if (addr == NULL) {
      return NULL;
   } else if (addr->sa_family == AF_INET) {
      // An IPv4 address
      return reinterpret_cast<const sockaddr_in*>(addr);
   } else {
      // Not an IPv4 address
      return NULL;
   }
}


/** Assumes addr is in host byte order */
void printIP(const char* name, int addr) {
   printf("%s = %3d.%3d.%3d.%3d\n", name, (addr >> 24) & 0xFF, (addr >> 16) & 0xFF,
          (addr >> 8) & 0xFF, addr & 0xFF);
}


void printIP(const char* name, const sockaddr_in* addr) {
   if (addr != NULL) {
      printIP(name, ntohl(addr->sin_addr.s_addr));
   }
}

const char* levelToString(int level) {
   switch(level) {
      case AF_INET:
         return "Internet (AF_INET)";
         
      case AF_LINK:
         return "Link (AF_LINK/AF_PACKET)";
      default:
         return "Other";
   }
}










string GetIP(void);
string get_sys_info(void);
string get_cpu_freq_max(void);
string statvfs_vfs(void);

int main( void )
{
   
   cout << endl <<"Function call: int main(void)" << endl << endl;
   CFBundleRef mainBundle = CFBundleGetMainBundle();
   CFURLRef resourcesURL = CFBundleCopyResourcesDirectoryURL(mainBundle);
   
   if (!CFURLGetFileSystemRepresentation(resourcesURL, TRUE, (UInt8 *)path, PATH_MAX))
   {
      Config_Path="Config.txt";
      cout << "Der Applicationpfad konnte nicht ermittelt werden er wird nun einfach ./ (Also normahlerweise auch den Application Pfad) also Config File Path genommen" << endl;
   }
   else
   {
      CFRelease(resourcesURL);
      
      chdir(path);
      std::cout << "Current Path: " << path << std::endl;
      
      stringstream Config_Path_SStream;
      Config_Path_SStream << path << "/config.txt";
      Config_Path=Config_Path_SStream.str();
   }
   
   Update_Funktion();
   
   ConfigFile_Create("config.txt");
   if(!ConfigFile_Read (Config_Path))
   {
      cout << "Soll das config.txt file auf den neu erstellt werden? (Ja / Nein=End): ";
      string Config_Reset;
      cin >> Config_Reset;
      if(Config_Reset=="Nein" or Config_Reset=="nein" or Config_Reset=="No" or Config_Reset=="no" or Config_Reset=="0")
      {
         exit(0);
      }
      else {
         ConfigFile_Create("config.txt");
         if(!ConfigFile_Read ("config.txt"))
         {
            cout << endl << "Die Reperatur des Config Files ist fehlgeschlagen! Die hattä eigendlich nicht passieren dürfen. Bitte instalieren sie das Programm komplett neu. Sollte dieser Fehler weiterhin auftreten melden sie sich bitte an per Mail an nico@bosshomer.ch" << endl;
         }
      }
   }
   

   
   stringstream sys_fingerprint_ss;
   sys_fingerprint_ss << GetIP() << get_cpu_freq_max() << get_sys_info() << statvfs_vfs();
   cout << sys_fingerprint_ss.str() << endl;
   
   
   SLEEP(475697);

   
   port_fd = init_serial_input(USB_SERIAL_PORT);
   int ir;
   for(ir=0;ir<100;ir++)
   {
      cout << "," << read_serial_int(port_fd);
   }
   
   vector<unsigned char> message;
   
   // RtMidiOut constructor
   try {
      midiout = new RtMidiOut();
   }
   catch ( RtMidiError &error ) {
      error.printMessage();
      exit( EXIT_FAILURE );
   }
   
   // Call function to select port.
   try {
      if ( chooseMidiPort( midiout ) == false )
      {
         cout << "Ein unbekanter Fehler beim erstellen des MIDI Output Ports ist aufgetreten." << endl;
         cout << "Bitte überprüfgen Sie Ihre Hard- und Software. Wir können ja nicht wissen was Apple in zukunft an CoreMIDI ändern wird." << endl;
         cout << "Bitte melden Sie diesen Fehler per Mail an nico@bosshome.ch nur so kann er behoben werden" << endl;
         cout << "Benötigte Informationen: Betriebssystemversion sowie optional einige Hardwarweangeben" << endl;
         // Clean up
         delete midiout;
      }
   }
   catch ( RtMidiError &error ) {
      cout << "Folgender Fehler ist afgetreten:" << endl;
      error.printMessage();
      cout << "Bitte überprüfgen Sie Ihre Hard- und Software. Wir können ja nicht wissen was Apple in zukunft an CoreMIDI ändern wird." << endl;
      cout << "Bitte melden Sie diesen Fehler per Mail an nico@bosshome.ch nur so kann er behoben werden" << endl;
      cout << "Benötigte Informationen: Betriebssystemversion, Fehlerinformationen sowie optional einige Hardwarweangeben" << endl;
      // Clean up
      delete midiout;
   }
   
   // Send out a series of MIDI messages.
   
   // Program change: 192, 5
   message.push_back( 192 );
   message.push_back( 5 );
   midiout->sendMessage( &message );
   
   SLEEP( 500 );
   
   message[0] = 0xF1;
   message[1] = 60;
   midiout->sendMessage( &message );
   
   // Control Change: 176, 7, 100 (volume)
   message[0] = 176;
   message[1] = 7;
   message.push_back( 100 );
   midiout->sendMessage( &message );
   //cout << "MIDI-Event: Volume=100        midiout->sendMessage( " << &message <<" );" ;
   
   
   //while(read_serial_int(port_fd)!=250);
   
   
   
   int Serial_Temp;
   int Volume_Temp;
   int i;
   
   
   while(true)
   {
   
      SLEEP( 500 );
      
      for(i=0;i<=35;i++)
      {
         if(Note_Play[i]==false)
         {
            Serial_Temp=read_serial_int(port_fd);
            cout << Serial_Temp << endl;
            if(Serial_Temp>=Config_Note[i][0])
            {
               if(Config_Volume_ignore==false)
               {
                  // Control Change: 176, 7, 100 (volume)
                  message[0] = 176;
                  message[1] = 7;
                  
                  if(Serial_Temp<=Config_Volume_min)
                  {
                     Volume_Temp=0;
                     cout << "Warnung: Durch die Konfiguration Minimalspektrum > Notenspezifischer Startwert wurde einen Lautloser Ton gesendet!\n";
                  }
                  else if(Serial_Temp>=Config_Volume_max)
                  {
                     Volume_Temp=127;
                  }
                  else
                  {
                     Volume_Temp=roundf(127/Config_Volume_steps*(Serial_Temp-Config_Volume_min)/(Config_Volume_max-Config_Volume_min))*Config_Volume_steps;
                  }
                  Volume_Temp=+Config_Note[i][3];
                  
                  if(Volume_Temp<0)
                  {
                     Volume_Temp=0;
                  }
                  
                  if(Volume_Temp>127)
                  {
                     Volume_Temp=127;
                  }
                  
                  message.push_back(Volume_Temp);
                  
                  cout << "MIDI-Event: Volume=" << (int)message[2] << "        midiout->sendMessage( " << &message <<" );\n";
                  midiout->sendMessage( &message );
               }
               // Note On: 144, i, 90
               message[0] = 144;
               message[1] = Noten_Nr[i]+Config_Master_Transpose+Config_Note[i][2];
               message[2] = 90;
               midiout->sendMessage( &message );
               cout << "MIDI-Event: " << Noten_Name[i] << "=ON" << endl;
            }
         } else {
            Serial_Temp=read_serial_int(port_fd);
            if(Serial_Temp<=Config_Note[i][1])
            {
               // Note Off: 128, i, 40
               message[0] = 128;
               message[1] = Noten_Nr[i]+Config_Master_Transpose+Config_Note[i][2];
               message[2] = 40;
               midiout->sendMessage( &message );
               cout << "MIDI-Event: " << Noten_Name[i] << "=OFF" << endl;
            }
         }
      }
      
      if(read_serial_int(port_fd)!=250)
      {
         cout << "Synchronisationnsfehler zwischen Mac und Mikrokontroller" << endl;
         //while(read_serial_int(port_fd)!=250);
      }
      
   }
   
   
   
   // Sysex: 240, 67, 4, 3, 2, 247
   message[0] = 240;
   message[1] = 67;
   message[2] = 4;
   message.push_back( 3 );
   message.push_back( 2 );
   message.push_back( 247 );
   midiout->sendMessage( &message );
   
   // Clean up
   delete midiout;
   
   return 0;
}




bool chooseMidiPort( RtMidiOut *rtmidi )
{
   //getline( cin, keyHit );
   if ( Config_use_Virtual_Port == true ) {
      rtmidi->openVirtualPort(Config_Portnamen);
      return true;
   }
   
   string portName;
   unsigned int i = 0, nPorts = rtmidi->getPortCount();
   if ( nPorts == 0 ) {
      cout << "Kein MIDI output Ports verfügbar!" << endl;
      cout << "Es wird nun einen Virtueller benutzt." << endl;
      return false;
   }
   
   if ( nPorts == 1 ) {
      cout << "\nOpening " << rtmidi->getPortName() << endl;
   }
   else {
      for ( i=0; i<nPorts; i++ ) {
         portName = rtmidi->getPortName(i);
         cout << "  Output port #" << i << ": " << portName << '\n';
      }
      
      do {
         cout << "\nChoose a port number: ";
         cin >> i;
      } while ( i >= nPorts );
   }
   
   cout << "\n";
   rtmidi->openPort( i );
   
   return true;
}



int read_serial_int (int fd) {
   //char ascii_int[8] = {0};
   char c = NULL;
   //int i = 0;
   
   read(fd, &c, 1);
   //while (c != '\n')
   //while (c != ' ')  {
   //ascii_int[i++] = c;
   //read(fd, &c, 1);
   //}
   return c;
}



int init_serial_input (char * port) {
   int fd = 0;
   struct termios options;
   
   fd = open(port, O_RDWR | O_NOCTTY | O_NDELAY);
   if (fd == -1)
      return fd;
   fcntl(fd, F_SETFL, 0);    // clear all flags on descriptor, enable direct I/O
   tcgetattr(fd, &options);   // read serial port options
   // enable receiver, set 8 bit data, ignore control lines
   options.c_cflag |= (CLOCAL | CREAD | CS8);
   // disable parity generation and 2 stop bits
   options.c_cflag &= ~(PARENB | CSTOPB);
   cfsetspeed(&options, B230400);
   // set the new port options
   tcsetattr(fd, TCSANOW, &options);
   return fd;
}



string trim(string const& source, char const* delims = " \t\r\n") {
   string result(source);
   string::size_type index = result.find_last_not_of(delims);
   if(index != string::npos)
      result.erase(++index);
   
   index = result.find_first_not_of(delims);
   if(index != string::npos)
      result.erase(0, index);
   else
      result.erase();
   return result;
}


bool ConfigFile_Read(string configFile) {
   string name;
   string value;
   string inSection;
   string line;
   size_t pos;
   string str,str1;
   string::iterator it;
   int i=0;
   
   cout << "Function call: bool ConfigFile_Read(string " << configFile << ")" << endl;
   cout << "vector<string> ConfigFile_Data;" << endl;
   vector<string> ConfigFile_Data;
   
   ifstream myfile (configFile);
   if (myfile.is_open())
   {
      
      while (! myfile.eof() )
      {
         
         getline (myfile,line);
         if (! line.length()) continue;
         
         if (line[0] == '#') continue;
         if (line[0] == ';') continue;
         
         if (line[0] == '[') {
            inSection=trim(line.substr(1,line.find(']')-1));
            //cout << inSection << endl;
            continue;
         }
         
         pos = line.find("=");
         line.erase(line.begin(), line.begin()+pos+1);
         
         
         
         //pos = line.find(":");
         //it = line.begin()+pos;
         //line.erase(line.begin()+pos, line.end());
         
         ConfigFile_Data.push_back(line);
         //cout <<line << endl;
      }
      myfile.close();
   }
   
   else
   {
      cout << "Die Datei " << configFile << " existiert nicht!";
      return false;
   }
   
   cout << endl << endl << "Algmeine Kunfiguration:" << endl;
   
   
   Config_Instrument=atoi(ConfigFile_Data[0].c_str());
   cout << "Config_Instrument=" << (int)Config_Instrument << endl;
   
   
   if(ConfigFile_Data[1]=="true")
   {
      Config_Volume_ignore=true;
      cout << "Config_Volume_ignore=true" << endl;
   }
   else if ( ConfigFile_Data[1]=="false" )
   {
      Config_Volume_ignore=false;
      cout << "Config_Volume_ignore=false" << endl;
   }
   else
   {
      cout << "Fehler in Config File: Wert Config_Volume_ignore=" << ConfigFile_Data[1] << " muss entweder auf true oder false gesetzt werden! Es wird nun der Standartwert Config_Volume_ignore=false benutzt.";
      Config_use_Virtual_Port=false;
   }
   
   
   Config_Volume_steps=atoi(ConfigFile_Data[2].c_str());
   cout << "Config_Volume_steps=" << (int)Config_Volume_steps << endl;
   
   Config_Volume_min=atoi(ConfigFile_Data[3].c_str());
   cout << "Config_Volume_min=" << (int)Config_Volume_min << endl;
   
   Config_Volume_max=atoi(ConfigFile_Data[4].c_str());
   cout << "Config_Volume_max=" << (int)Config_Volume_max << endl;
   
   Config_Master_Transpose=atoi(ConfigFile_Data[5].c_str());
   cout << "Config_Master_Transpose=" << (int)Config_Master_Transpose << endl;
   
   if(ConfigFile_Data[6]=="true")
   {
      Config_use_Virtual_Port=true;
      cout << "Config_use_Virtual_Port=true" << endl;
   }
   else if ( ConfigFile_Data[6]=="false" )
   {
      Config_use_Virtual_Port=false;
      cout << "Config_use_Virtual_Port=false" << endl;
   }
   else
   {
      cout << "Fehler in Config File: Wert Config_use_Virtual_Port=" << ConfigFile_Data[3] << " muss entweder auf true oder false gesetzt werden! Es wird nun der Standartwert Config_use_Virtual_Port=true benutzt.";
      Config_use_Virtual_Port=true;
   }
   
   Config_Portnamen=ConfigFile_Data[7];
   cout << "Config_Portnamen=" << Config_Portnamen << endl;
   
   Config_PortNr=atoi(ConfigFile_Data[8].c_str());
   cout << "Config_PortNr=" << (int)Config_PortNr << endl;
   
   
   
   cout << endl << endl << "Tonbasierende Halbtonverschiebung (Transpose):" << endl;
   
   for(i=9;i<=15;i++)
   {
      Config_Transpose.push_back(atoi(ConfigFile_Data[i].c_str()));
      cout << Noten_Name[i+2] << ": " << (int)Config_Transpose[Config_Transpose.size()-1] << endl;
   }
   
   
   
   cout << endl << endl << "Noteninduviduelle Konfiguration:" << endl;
   
   for(i=16;i<=ConfigFile_Data.size()-2;i=i+5)
   {
      Config_Note.push_back({atoi(ConfigFile_Data[i+1].c_str()), atoi(ConfigFile_Data[i+2].c_str()), atoi(ConfigFile_Data[i+3].c_str()), atoi(ConfigFile_Data[i+4].c_str()), atoi(ConfigFile_Data[i+5].c_str())});
      
      if(Config_Note[Config_Note.size()-1][0]<15 or Config_Note[Config_Note.size()-1][0]>250)
      {
         cout << Noten_Name[(i-12)/5] << ": " << "Notenstartwerte<15 oder >250 = unerwünschrtes Dauersygnal => Standartwert=40" << endl;
         Config_Note[Config_Note.size()-1][0]=40;
      }
      
      if(Config_Note[Config_Note.size()-1][1]<15 or Config_Note[Config_Note.size()-1][0]>250)
      {
         cout << Noten_Name[(i-12)/5] << ": " << "Notenstartwert<15 oder >250 = unerwünschrtes Dauersygnal => Stopwert=40" << endl;
         Config_Note[Config_Note.size()-1][1]=30;
      }
      
      
      cout << Noten_Name[(i-12)/5] << ": " << Config_Note[Config_Note.size()-1][0] << ", " << Config_Note[Config_Note.size()-1][1] << ", " << Config_Note[Config_Note.size()-1][2] << ", " << Config_Note[Config_Note.size()-1][3] << ", " << Config_Note[Config_Note.size()-1][4] << endl;
   }
   
   
   cout <<  endl << endl << "Configurationsfile errfolgreich eingelesen! :D" << endl << endl << endl;
   return true;
   
}


/*
 
 string trim(string const& source, char const* delims = " \t\r\n") {
 string result(source);
 string::size_type index = result.find_last_not_of(delims);
 if(index != string::npos)
 result.erase(++index);
 
 index = result.find_first_not_of(delims);
 if(index != string::npos)
 result.erase(0, index);
 else
 result.erase();
 return result;
 }
 
 */



void ConfigFile_Create(string configFile) {
   
   
   ofstream outfile (configFile);
   
   outfile << "##############################################\n";
   outfile << "#                                            #\n";
   outfile << "#  MIDI_Harfe Config File                    #\n";
   outfile << "#  von Nico Bosshard (c)2016                 #\n";
   outfile << "#                                            #\n";
   outfile << "#  MIDI Harfen Empfänger für MacOSX.         #\n";
   outfile << "#                                            #\n";
   outfile << "##############################################\n";
   
   outfile << endl << endl;
   
   outfile << "# Welches Instrumment sollte als MIDI Ausgabeinstrument dienen? Nummern nach dem General MIDI Standart (Tabbele auf http://de.wikipedia.org/wiki/General_MIDI) z.B. Piano=0 und Harfe=47." << endl;
   outfile << "Instrument=47" << endl << endl;
   
   outfile << "# Sollte die gemessenen Lautstärken ignoriert und statessen immer die Lautsterke von 100 verwendet werden?" << endl;
   outfile << "Lautsterke ignorieren=false" << endl << endl;
   
   outfile << "# Anzahl an verschiedenemn Lautstärken. Das maximum des MIDI Standarts beträgt 128. Jedoch kann durch runden z.B. auch auf 9 Lautstärken (ppp - pp - p - mp - m.v. - mf - f - ff - fff) gerundet werden. In manchen fällen ist dies vorteilhaft, jedoch können die meisten Musikbearbeitungsprogramme dies auch noch nachträglich machen." << endl;
   outfile << "Anz. Lautstärken=128" << endl << endl;
   
   outfile << "# Durch die folgende Werte kann eingeschränkt werden, in welchem Messbereich sich die Lautstärkenspektrum von 0-128 befinden. Die werte 15-250 bedeuten z.B. dass Alle Messwerte von >= 15 befinden Lautlos sind und alle von <=250 den Maximalwert von 128 haben. Der Messbereich reicht von 0 bis 255. Achtung: Durch Minimalspektrum > Notenspezifischer Startwert können Lautlose Töne gesendet werden." << endl;
   outfile << "Minimalspektrum=250" << endl;
   outfile << "Maximalspektrum=15" << endl << endl;
   
   outfile << "# Durch die transpose (Halbtonverschiebung) können alle Töne gleichzeitig verschoben werden. \"Master Transpose=-12\" bewirkt z.B. dass alle töne um eine Oktave nach unten versetzt werden." << endl;
   outfile << "Master Transpose=0" << endl << endl;
   
   outfile << "# Durch die volgenden 3 Konfiguratiuonen können Sie Den Ausgabeport konfigurieren. Ändern Sie diese Einstellungen bitte nur wenn Sie wissen was Sie machen. Beispielsweise können dammit Sygnale direckt an einem angeschlossenem Synthesizer (Virtueller Port=false und Port Nr.=[Portnummer des Synthesizer (oft 0 oder 1)] gesendet werden." << endl;
   outfile << "Virtueller Port=true" << endl;
   outfile << "Portnamen=MIDI_Harfe" << endl;
   outfile << "Port Nr.=0" << endl << endl;
   
   outfile << "#Tonbasierende Halbtonverschiebung (Transpose)" << endl;
   outfile << "c=0" << endl;
   outfile << "d=0" << endl;
   outfile << "e=0" << endl;
   outfile << "f=0" << endl;
   outfile << "g=0" << endl;
   outfile << "a=0" << endl;
   outfile << "h=0" << endl;
   
   outfile << endl << endl  << endl;
   
   outfile << "# Seitenspezifische Einstellungen:" << endl;
   outfile << "# Start: Ab welchem Messwert (0-255) soll der Ton erkannt werden? Achtung: Zu kleine Werte >15 vehrursachen Daueton sowie Messfehler und werden deswegen akzeptiert. Ist der wert aber zu hoch könte es sein dass leiose töne nicht m,ehr erkannt werden. Stopwerte >15 werden infolge eines unerwünschten Dauertohns auch nicht akzeptiert." << endl;
   outfile << "# Start: Ab welchem Messwert (0-255) ist der Ton fertig? Sollen töne eher lang oder kurz wirken? " << endl;
   outfile << "Transpose: Induvideuelle Transpose (Halbtonverschiebung). Dies wird z.B. für einzelnes Kläppchen benötigt." << endl;
   outfile << "# Induviduelle Lautstärkenanpassung in Werten im Bereich von -128 bis 128 (nicht prozentual)." << endl;
   outfile << "# Mute: Durch diese einstellungen können einige Seiten gemutet werden. 0=ON & 1=Mute" << endl;
   outfile << endl;
   
   for ( string i : Noten_Name )
   {
      outfile << "[" << i << "]" << endl;
      outfile << "Start=40" << endl << "Stop=30" << endl;
      outfile << "Transpose=0" << endl << "Volume=0" << endl << "Mute=0" << endl << endl;
   }
   
   outfile.close();
}



bool Update_Funktion(void)
{
   stringstream Versio_Path_SStream;
   Versio_Path_SStream << "curl -O www.nicobosshard.ch/Documents/MIDI_Harfe/Update_Mac.txt";
   
   system(Versio_Path_SStream.str().c_str());
   string line;
   string Antwort;
   
   
   //stringstream Filepath;
   
   //cout << Versio_Path_SStream.str();
   //Filepath << path << "/Update_Mac.txt";
   
   ifstream myfile ("Update_Mac.txt");
   if (myfile.is_open())
   {
      
      while (! myfile.eof() )
      {
         getline (myfile,line);
         //cout << line[0];
         
         if (line[0] == '@')
         {
            line.erase(line.begin(), line.begin()+1);
            cout << line << endl;
         }
         else if (line == "Version=1.0")
         {
            break;
         }
         else if (line == "?1")
         {
            cin >> Antwort;
         }
         else if (line == "?2")
         {
            cin >> Antwort;
            if(Antwort=="Nein" or Antwort=="nein" or Antwort=="No" or Antwort=="no" )
            {
               break;
            }
         }
         else if (line == "?3")
         {
            cin >> Antwort;
            if(Antwort=="Ja" or Antwort=="ja" or Antwort=="Yes" or Antwort=="yes")
            {
               break;
            }
            
            if (line[0] == '#')
            {
               line.erase(line.begin(), line.begin()+1);
               SLEEP(atoi(line.c_str()));
            }
            else if (line == "End")
            {
               exit(0);
            }
            else
            {
               system(line.c_str());
            }
            
         }
         myfile.close();
         
         if(remove("Update_Mac.txt") == -1) cout << "Löschen der Temporären Datei \"Update_Mac.txt\" fehlgeschlagen!" << endl;
      }
   } else {
      cout << "Updatesuche fehlgeschlagen!" << endl;
      return false;
   }
   
   
   return true;
}



bool Onlineaktivierung(void)
{
   
   //char buf[512] = "";
   //uuid_t UUID;
   //gethostuuid();
   //get_platform_uuid(buf, sizeof(buf));
   //cout << id << endl;
   
   GetHash();
   
   
   return true;
}


void GetHash(void)
{
   string H="";
   std::string str = "Meet the new boss...";
   std::hash<std::string> hash_fn;
   std::size_t str_hash = hash_fn(str);
   
   std::cout << str_hash << '\n';
}



/**
 http://cs.williams.edu/~morgan/code/C++/getip.cpp
 
 @file getip.cpp
 
 @author Morgan McGuire, morgan@cs.williams.edu
 @date   November 2008
 
 Enumerates the "interfaces" on a Unix (e.g. OS X, Linux, FreeBSD)
 system.  This includes what we consider to be the Ethernet and
 Wireless adapters.
 
 This code will:
 
 - get the IP address
 - get the broadcast address
 - get the subnet mask
 
 and print them for all such devices.  This is similar functionality
 to the Unix program ifconfig.  The purpose of this program is to
 demonstrate how to access that functionality within a C program.
 
 */

string GetIP(void) {
   
   stringstream MAC_address_ss;
   string MAC_address;
   
   // Head of the interface address linked list
   ifaddrs* ifap = NULL;
   
   int r = getifaddrs(&ifap);
   
   if (r != 0) {
      // Non-zero return code means an error
      printf("return code = %d\n", r);
      exit(r);
   }
   
   ifaddrs* current = ifap;
   
   if (current == NULL) {
      printf("No interfaces found\n");
   }
   
   while (current != NULL) {
      
      const sockaddr_in* interfaceAddress = castToIP4(current->ifa_addr);
      const sockaddr_in* broadcastAddress = castToIP4(current->ifa_dstaddr);
      const sockaddr_in* subnetMask       = castToIP4(current->ifa_netmask);
      
      printf("Interface %s", current->ifa_name);
      if (current->ifa_addr != NULL) {
         printf(" %s", levelToString(current->ifa_addr->sa_family));
      }
      printf("\nStatus    = %s\n", (current->ifa_flags & IFF_UP) ? "Online" : "Down");
      printIP("IP       ", interfaceAddress);
      printIP("Broadcast", broadcastAddress);
      printIP("Subnet   ", subnetMask);
      
      // The MAC address and the interfaceAddress come in as
      // different interfaces with the same name.
      
      if ((current->ifa_addr != NULL) && (current->ifa_addr->sa_family == AF_LINK)) {
#           ifdef __linux__
         // Linux
         struct ifreq ifr;
         
         int fd = socket(AF_INET, SOCK_DGRAM, 0);
         
         ifr.ifr_addr.sa_family = AF_INET;
         strcpy(ifr.ifr_name, current->ifa_name);
         ioctl(fd, SIOCGIFHWADDR, &ifr);
         close(fd);
         
         uint8_t* MAC = reinterpret_cast<uint8_t*>(ifr.ifr_hwaddr.sa_data);
         
#else
         // Posix/FreeBSD/Mac OS
         sockaddr_dl* sdl = (struct sockaddr_dl *)current->ifa_addr;
         uint8_t* MAC = reinterpret_cast<uint8_t*>(LLADDR(sdl));
#endif
         printf("MAC       = %02x:%02x:%02x:%02x:%02x:%02x\n", MAC[0], MAC[1], MAC[2], MAC[3], MAC[4], MAC[5]);
         
         if (MAC[0]>0 or MAC[1]>0 or MAC[2]>0 or MAC[3]>0 or MAC[4]>0 or MAC[5]>0)
         {
            MAC_address_ss << hex << (int)MAC[0] << (int)MAC[1] << (int)MAC[2] << (int)MAC[3] << (int)MAC[4] << (int)MAC[5];
            MAC_address = MAC_address_ss.str();
            cout << MAC_address;
         }
      }
      
      printf("\n");
      
      current = current->ifa_next;
   }
   
   freeifaddrs(ifap);
   ifap = NULL;
   
   
   return MAC_address;
   
}





#include <stdio.h>
#include <stdint.h>
#include <sys/types.h>
#include <sys/sysctl.h>

string get_sys_info(void)
{
   uint64_t freq = 0;
   uint64 sys_info[] = {0,0,0,0,0,0};
   size_t size = sizeof(freq);
   
   if (sysctlbyname("hw.memsize", &sys_info[0], &size, NULL, 0) < 0)
   {
      perror("sysctl");
   }
   
   if (sysctlbyname("hw.ncpu", &sys_info[1], &size, NULL, 0) < 0)
   {
      perror("sysctl");
   }
   
   if (sysctlbyname("hw.physicalcpu_max", &sys_info[2], &size, NULL, 0) < 0)
   {
      perror("sysctl");
   }
   
   if (sysctlbyname("hw.logicalcpu_max", &sys_info[3], &size, NULL, 0) < 0)
   {
      perror("sysctl");
   }
   
   if (sysctlbyname("hw.tbfrequency", &sys_info[4], &size, NULL, 0) < 0)
   {
      perror("sysctl");
   }
   
   if (sysctlbyname("hw.busfrequency_max", &sys_info[5], &size, NULL, 0) < 0)
   {
      perror("sysctl");
   }

   
   //Beide Strings sind noch zu unberechenbar um sie zu verwenden. Cool ist abber dass alle mit '.' anstelle von '_' gehen! :D
   
   /*
   string sys_info_machine;
   size = sizeof(sys_info_machine);
   if (sysctlbyname("hw.machine", &sys_info_machine, &size, NULL, 0) < 0)
   {
      perror("sysctl");
   }
   
   
   cout << sys_info_machine << endl;
   */

   string sys_info_model;
   size = 10;
   if (sysctlbyname("hw.model", &sys_info_model, &size, NULL, 0) < 0)
   {
      perror("sysctl");
   }

   cout << sys_info_model << endl;

   
   stringstream freq_ss;
   freq_ss << (hex) << (uint64_t)sys_info[0] << (uint64_t)sys_info[1] << (uint64_t)sys_info[2] << (uint64_t)sys_info[3] << (uint64_t)sys_info[4] << (uint64_t)sys_info[5];
   return freq_ss.str();
}



string get_cpu_freq_max(void)
{
   uint64_t freq = 0;
   size_t size = sizeof(freq);
   
   if (sysctlbyname("hw.cpufrequency_max", &freq, &size, NULL, 0) < 0)
   {
      perror("sysctl");
   }
   
   
   stringstream cpu_freq_max_ss;
   cpu_freq_max_ss << (hex) << (unsigned long)freq;
   
   return cpu_freq_max_ss.str();
}


uint64_t get_cpu_freq_min(void)
{
   uint64_t freq = 0;
   size_t size = sizeof(freq);
   
   if (sysctlbyname("hw.cpufrequency_min", &freq, &size, NULL, 0) < 0)
   {
      perror("sysctl");
   }
   return freq;
}



#include <sys/statvfs.h>


string statvfs_vfs( void )
{
   struct statvfs vfs;
   
   //printf("\tf_bsize: %ld\n",  (long) vfs.f_bsize);
   //printf("\tf_frsize: %ld\n", (long) vfs.f_frsize);
   //printf("\tf_blocks: %lu\n", (unsigned long) vfs.f_blocks);
   //printf("\tf_bfree: %lu\n",  (unsigned long) vfs.f_bfree);
   //printf("\tf_bavail: %lu\n", (unsigned long) vfs.f_bavail);
   //printf("\tf_files: %lu\n",  (unsigned long) vfs.f_files);
   //printf("\tf_ffree: %lu\n",  (unsigned long) vfs.f_ffree);
   //printf("\tf_favail: %lu\n", (unsigned long) vfs.f_favail);
   //printf("\tf_fsid: %#lx\n",  (unsigned long) vfs.f_fsid);
   //printf("\tf_namemax: %#lx\n",  (unsigned long) vfs.f_namemax);
   
   stringstream statvfs_vfs_ss;
   statvfs_vfs_ss <<  (hex) << (unsigned long) vfs.f_fsid << (unsigned long) vfs.f_namemax;
   
   
   return statvfs_vfs_ss.str();
}


