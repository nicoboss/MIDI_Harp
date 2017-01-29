// -----------------------------------------------------------------------
// <copyright file="MIDI_Harp_Teensy.ino">
// Nico Bosshard
// </copyright>
// -----------------------------------------------------------------------

#include "ADC.h" //Importieren der ADC Bibliothek zum Ansteuern der ADC_Ports
#define USBSERIAL Serial //SerialUSB Definition für den Teensy Microkontroller
#define Syncbyte B10000000 //Das Synchbyte beträgt immer 128 => binär 10000000
//#define LED 13 //Das Power-LED befindet sich auf Port 13
#define USB_MIDI_Schalter 23 //Das Power-LED befindet sich auf Port 13

//Folgende Funktion wird bei jedem Bootvorgang automatisch einmal ausgeführt
void setup() {
  //Enschalten des roten Power-LEDs
  pinMode(LED_BUILTIN, OUTPUT);
  digitalWrite(LED_BUILTIN, HIGH);
  //Setzen des USB MIDI Schalters als input.
  pinMode(USB_MIDI_Schalter, INPUT_PULLDOWN);
}


//Diese Funktion wird nach dem Bootvorgang endlos ausgeführt
void loop() {
  //DDRD ist ein direkter Zugang zu Port D mit all seinen Pins. Durch das Setzen dieses Ports auf 255 werden alle Pins auf Output gesetzt.
  DDRD = B11111111;
  //PORTD ist ein direkter Zugang zu Port D mit all seinen Pins. Durch das Setzen auf 0 werden alle Pins auf GND geschaltet.
  PORTD = B00000000;
  
  //Generieren eines neuen ADC Objekts
  ADC *adc = new ADC();
  pinMode(A5, INPUT); //Pin A5 als ADC Input
  pinMode(A2, INPUT); //Pin A2 als ADC Input
  
  //Einstellen des ADC 0 (untere Harfenhälfte)
  adc->setResolution(16, ADC_0); //Setzen der ADC-Auflösung auf das Maximum von 16-bit.
  adc->setConversionSpeed(ADC_VERY_HIGH_SPEED, ADC_0); //Möglichst hohe Konversationsgeschwindigkeit (über den Spezifikationen des Bauteils)
  adc->setSamplingSpeed(ADC_HIGH_SPEED, ADC_0); //Schnellstmöglicher Ladezyklus des ADC Kondensators.
  adc->setReference(ADC_REF_3V3, ADC_0); //Setzen der Refernezspannung auf 3.3V
  
  //Einstellen des ADC 1 (obere Harfenhälfte)
  adc->setResolution(16, ADC_1); //Setzen der ADC-Auflösung auf das Maximum von 16-bit.
  adc->setConversionSpeed(ADC_VERY_HIGH_SPEED, ADC_1); //Möglichst hohe Konversationsgeschwindigkeit (über den Spezifikationen des Bauteils)
  adc->setSamplingSpeed(ADC_HIGH_SPEED, ADC_1); //Schnellstmöglicher Ladezyklus des ADC Kondensators.
  adc->setReference(ADC_REF_3V3, ADC_1); //Setzen der Refernezspannung auf 3.3V
  
  Serial.begin(115200); //Setzen der virtuellen Symbolrate auf 115200 Bd. Dieser Wert wird vom Serial zu USB Wandler jedoch ignoriert.
  ADC::Sync_result adc_messwert; //Die Variable adc_messwert ist ein struct welcher die nach einer analogSyncRead Messung die Messerte beider ADCs beinhaltet.
  
  //Im folgendem Block werden die später benutzten Variabeln deklariert und inizialisiert.
  unsigned short adc0_value;
  unsigned short adc1_value;
  char messungen[65];
  signed int adc_value_old[32] = {};
  signed int adc_value[32] = {};
  signed int calibration[32] = {};
  bool MIDI_aktiviert;
  bool MIDI_play[32] = {};
  signed long integral2D[256][32] = {{}};
  signed long integralwert[32] = {};
  unsigned char integralcounter[32] = {};

  signed long ableitung1wert[32] = {};
  signed long ableitung1wert_old[32] = {};
  signed long ableitung2wert[32] = {};
  unsigned int second_trigger_count[32] = {};
  unsigned int third_trigger_count[32] = {};

  unsigned char MidiNoteNr[] = {
        32, 34,
        36, 38, 39, 41, 43, 44, 46,
        48, 50, 51, 53, 55, 56, 58,
        60, 62, 63, 65, 67, 68, 70,
        72, 74, 75, 77, 79, 80, 82,
        84, 86, 87, 89, 91, 92, 94
    };
  
  unsigned char messung = 0;
  unsigned char hhigh;
  unsigned char saite;
  unsigned char siebzehner[16];

  //Generieren der zur Performanceoptimierung benutzten 17ner Reihe für die Analogmultiplexerkomunikation
  for (unsigned char i=0; i < 15; ++i) siebzehner[i]=17*(i+1);
  siebzehner[15]=0;

  
  if (digitalRead(USB_MIDI_Schalter) == LOW) {
    MIDI_aktiviert = false;
  } else {
    MIDI_aktiviert = true;
  }


  //Start des main loops
  messen:
  {
    messungen[0] = Syncbyte; //Setzen des ersten Bytes der Messreihe als Synchbyte
    hhigh = 128; //Das nächste high-byte wird ein hhigh byte sein => 128 addieren.
    messung=1; //Setzen des Messzählers auf 1
    saite=0; //Setzen der Saitennummer auf 0

    //Prüfen ob USB MIDI an ist.
    if (MIDI_aktiviert) {
      //Falls USB-MIDI an ist, erfolgt eine microkontrollerseitige Auswertung
      for (unsigned char i=0; i < 16; ++i){ //++i da schneller als i++ da pre-increment
        adc_messwert = adc->analogSyncRead(A5, A2); //Gleichzeitiges Messen der beiden ADCs
        PORTD = siebzehner[i]; //Kommunikation mit dem Analogmultiplexer
        adc_value_old[saite]=adc_value[saite];
        adc_value[saite]=(unsigned short)adc_messwert.result_adc0 >> 1; //Saitennummerngeordnetes speichern des ADC 0 Wertes in ein Array
        adc_value_old[saite+16]=adc_value[saite+16];
        adc_value[saite+16]=(unsigned short)adc_messwert.result_adc1 >> 1; //Saitennummerngeordnetes speichern des ADC 1 Wertes in ein Array
        for (int i=saite; i <= saite+16; i += 16) { //Loopen durch beide gemessenen Werte
          if (adc_value[i]+calibration[i] > 16383) --calibration[i]; else ++calibration[i]; //Mittelwertsannäherungsberechnung
          adc_value[i] = abs(adc_value[i] + calibration[i] - 16383); //Anwenden der Mittelwertsannäherung auf den aktuellen Messwert
          integralwert[i] += adc_value[i] - integral2D[integralcounter[i]][i]; //Integralberechnung
          integral2D[integralcounter[i]][i]=adc_value[i]; //Speichern des Integralwerts in Array
          integralcounter[i]+=16; //Integralzähler um 16 erhöhen um nach 16 Messungen um mit 256 einen Overflow auszulösen
          ableitung1wert_old[i] = ableitung1wert[i]; //Für die Berechnung der 2. Ableitung wird der vorherige 1. Ableitung Wert benötigt.
          ableitung1wert[i] = adc_value_old[i] - adc_value[i]; //Berechnung der 1. Ableitung
          
          if(MIDI_play[i]) { //Falls die momentan verarbeitete Saite schon gespielt wird
            if(integralwert[i] < 50000) { //Falls der Integralwert 50'000 unterschreitet wird ein Notenstopp gesedet
              usbMIDI.sendNoteOff(MidiNoteNr[i], 100, 1); //Senden des Notenstopps
              MIDI_play[i] = false; //Die Saite wird nun als nicht gespielt erkannt
            }
          } else {
            if (second_trigger_count[i]==0) second_trigger_count[i]=1; //Verhindert Bitshift-Operator mit 0
            if (third_trigger_count[i]==0) third_trigger_count[i]=1; //Verhindert Bitshift-Operator mit 0
            ableitung2wert[i] = ableitung1wert_old[i] - ableitung1wert[i]; //Berechnen der 2. Ableitung
            if(ableitung2wert[i] < -7000 || ableitung2wert[i] > 7000) { //Prüft den Wert der 2. Ableitung
              second_trigger_count[i] = (second_trigger_count[i] << 6) - 1; //Verschiebt alle Bits um 6 nach links und Ergebniss - 1
            } else {
              second_trigger_count[i] >>= 1; //Verschiebt alle Bits um 1 nach rechts
            }
            if(adc_value[i] < -8000 || adc_value[i] > 8000) { //Prüft den Wert der Messwerte (Stammfunktion)
              third_trigger_count[i] = (third_trigger_count[i] << 6) - 1; //Verschiebt alle Bits um 6 nach links und Ergebniss - 1
            } else {
              third_trigger_count[i] >>= 1; //Verschiebt alle Bits um 1 nach rechts
            }
            //Prüfen ob alle drei Bedingungen zum Erkennen einer gespielten Saite erfüllt sind
            if(integralwert[i] > 175000 && second_trigger_count[i] > 262144 && third_trigger_count[i] > 262144) {
              usbMIDI.sendNoteOn(MidiNoteNr[i], 100, 1); //Senden des Notenstarts
              MIDI_play[i] = true; //Die Saite wird nun als gespielt erkannt
              second_trigger_count[i]=1; //Reset des second_trigger_count
              third_trigger_count[i]=1; //Reset des third_trigger_count
            }
          }
        }
        ++saite; //Erhöhen der Saitennummer per pre-increment
      }
    } else {
      for (unsigned char i=0; i < 16; ++i){ //++i da schneller als i++ da pre-increment
        adc_messwert = adc->analogSyncRead(A5, A2); //Gleichzeitiges Messen der beiden ADCs
        PORTD = siebzehner[i]; //Kommunikation mit dem Analogmultiplexer
        adc0_value = (unsigned short)adc_messwert.result_adc0 >> 1; //Speichern des ADC 0 Wertes
        adc1_value = (unsigned short)adc_messwert.result_adc1 >> 1; //Speichern des ADC 1 Wertes
        messungen[messung++] = (char)(hhigh + (adc0_value >> 8)); hhigh=0; //Speichern des high- oder hhigh-byte in die Messreihe
        messungen[messung++] = (char)adc0_value; //Speichern des low-byte in die Messreihe
        messungen[messung++] = (char)(adc1_value >> 8); //Speichern des high-byte in die Messreihe
        messungen[messung++] = (char)adc1_value; //Speichern des low-byte in die Messreihe
      }
      Serial.write(messungen, 65); //Senden der Messreihe an den Serial zu USB Wandler => PC
    }
  }
  goto messen; //Wiederholen des main-loops
}
