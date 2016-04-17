//*****************************************//
//  MIDI_Harfe
//  von Nico Bosshard (c)2016
//
//  MIDI Harfen Empfänger für MacOSX.
//
//*****************************************//

#include <iostream>
#include <cstdlib>
#include "RtMidi.h"
#include <fcntl.h>
#include <fstream>
#include <termios.h>
#include <string>
#include <vector>

using namespace std;

//#define USB_SERIAL_PORT "/dev/tty.usbserial-0000103D" // (OSX Power Book)
//#define USB_SERIAL_PORT  "/dev/cu.usbserial-3B1" // (OSX Mac Book)
//#define USB_SERIAL_PORT "/dev/tty.usbserial-0000103D" // (Linux Ubuntu Mac Book)
//#define USB_SERIAL_PORT "/dev/tty.usbserial-0000103D"
#define USB_SERIAL_PORT "/dev/cu.usbserial-FTUPO2WD"

int port_fd;

int init_serial_input(char * port);
int read_serial_int(int fd);

void ConfigFile_Read(string configFile);
void ConfigFile_Create(string configFile);

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

vector< vector<int> > Config_Notes;

vector<string> Noten_Name { "C", "D", "E", "F", "G", "A", "H",
                            "c", "d", "e", "f", "g", "a", "h",
                            "c'", "d'", "e'", "f'", "g'", "a'", "h'",
                            "c''", "d''", "e''", "f''", "g''", "a''", "h''",
                            "c'''", "d'''", "e'''", "f'''", "g'", "a'''", "h'''"};



int main( void )
{
   
   ConfigFile_Create("config.txt");
   ConfigFile_Read ("config.txt");
   
   
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
        if ( chooseMidiPort( midiout ) == false ) goto cleanup;
    }
    catch ( RtMidiError &error ) {
        error.printMessage();
        goto cleanup;
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
    
    int i;
    for(i=30;i<=110;i++)
    {
        // Note On: 144, 64, 90
        message[0] = 144;
        message[1] = i;
        message[2] = 90;
        midiout->sendMessage( &message );
        
        SLEEP( 200 );
        
        // Note Off: 128, 64, 40
        message[0] = 128;
        message[1] = i;
        message[2] = 40;
        midiout->sendMessage( &message );
    }
    
    for(i=109;i>=30;i--)
    {
        // Note On: 144, 64, 90
        message[0] = 144;
        message[1] = i;
        message[2] = 90;
        midiout->sendMessage( &message );
        
        SLEEP( 20 );
        
        // Note Off: 128, 64, 40
        message[0] = 128;
        message[1] = i;
        message[2] = 40;
        midiout->sendMessage( &message );
    }
    
    
    SLEEP( 500 );
    
    // Control Change: 176, 7, 40
    message[0] = 176;
    message[1] = 7;
    message[2] = 40;
    midiout->sendMessage( &message );
    
    SLEEP( 500 );
    
    // Sysex: 240, 67, 4, 3, 2, 247
    message[0] = 240;
    message[1] = 67;
    message[2] = 4;
    message.push_back( 3 );
    message.push_back( 2 );
    message.push_back( 247 );
    midiout->sendMessage( &message );
    
    // Clean up
cleanup:
    delete midiout;
    
    return 0;
}

bool chooseMidiPort( RtMidiOut *rtmidi )
{
    cout << "\nWould you like to open a virtual output port? [y/N] ";
    
    string keyHit;
    getline( cin, keyHit );
    if ( keyHit == "y" ) {
        rtmidi->openVirtualPort();
        return true;
    }
    
    string portName;
    unsigned int i = 0, nPorts = rtmidi->getPortCount();
    if ( nPorts == 0 ) {
        cout << "No output ports available!" << endl;
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
   cfsetspeed(&options, B115200);
   // set the new port options
   tcsetattr(fd, TCSANOW, &options);
   return fd;
}



#include <fstream>

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


void ConfigFile_Read(string configFile) {
   string name;
   string value;
   string inSection;
   string line;
   size_t pos;
   string str,str1;
   string::iterator it;
   
   vector<int> ConfigFile_Data;
   
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
         cout <<line << endl;
      }
      myfile.close();
   }
   
   else cout << "Unable to open file";
   
   cout << ConfigFile_Data.size();
   
   int i;
   for(i=10;i>ConfigFile_Data.size();i++)
   {
            //std::vector<int> Temp(ConfigFile_Data[i], ConfigFile_Data[i+1], ConfigFile_Data[i+2], ConfigFile_Data[i+3], ConfigFile_Data[i+4]);
      Config_Notes.push_back({ConfigFile_Data[i], ConfigFile_Data[i+1], ConfigFile_Data[i+2], ConfigFile_Data[i+3], ConfigFile_Data[i+4]});
         
         //new vector<int> {ConfigFile_Data[i], ConfigFile_Data[i+1], ConfigFile_Data[i+2], ConfigFile_Data[i+3], ConfigFile_Data[i+4]}
   }
   
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

   outfile << "##############################################" << endl;
   outfile << "#                                            #" << endl;
   outfile << "#  MIDI_Harfe Config File                    #" << endl;
   outfile << "#  von Nico Bosshard (c)2016                 #" << endl; 
   outfile << "#                                            #" << endl;
   outfile << "#  MIDI Harfen Empfänger für MacOSX.         #" << endl;
   outfile << "#                                            #" << endl;
   outfile << "##############################################" << endl;
   
   outfile << endl << endl;
   
   outfile << "Instrument (Piano->1, Harfe->47)=47" << endl;
   outfile << "Master Value (0-128)=128" << endl;
   outfile << "Master Transpose=0" << endl << endl;
   
   
   outfile << "#Tonbasierende Halbtonverschiebung (Transpose)" << endl;
   outfile << "C=0" << endl;
   outfile << "D=0" << endl;
   outfile << "E=0" << endl;
   outfile << "F=0" << endl;
   outfile << "G=0" << endl;
   outfile << "A=0" << endl;
   outfile << "H=0" << endl;
   
   outfile << endl << endl;
   

   for ( string i : Noten_Name )
   {
      outfile << "[" << i << "]" << endl;
      outfile << "Start=20" << endl << "Stop=18" << endl;
      outfile << "Transpose=0" << endl << "Value=0" << endl << "Mute=0" << endl << endl;
   }

   outfile.close();
}
