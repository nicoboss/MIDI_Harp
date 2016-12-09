//#include <MIDI.h>
#include "ADC.h"
#define USBSERIAL Serial       // for Leonardo, Teensy, Fubarino
#define Syncbyte B10000000

void setup() { 
}


void loop() {

/*
  while(true) {
    usbMIDI.sendNoteOn(66, 100, 1);
    delay(250);
    usbMIDI.sendNoteOff(66, 100, 1);
    delay(100);
  }
*/
  
  // put your setup code here, to run once:
  DDRD = B11111111;  // sets Arduino Port D to output
  PORTD = 0;
  pinMode(13, OUTPUT);
  digitalWrite(13, HIGH);   // turn the LED on (HIGH is the voltage level)

  ADC *adc = new ADC(); // adc object

  pinMode(A5, INPUT); //Diff Channel 0 Positive
  pinMode(A2, INPUT); //Diff Channel 0 Negative
  
  //adc->setAveraging(32, ADC_0); // set number of averages
  adc->setResolution(16, ADC_0); // set bits of resolution
  adc->setConversionSpeed(ADC_VERY_HIGH_SPEED, ADC_0); // change the conversion speed
  adc->setSamplingSpeed(ADC_HIGH_SPEED, ADC_0); // change the sampling speed
  adc->setReference(ADC_REF_3V3, ADC_0);
  //adc->enablePGA(64,ADC_0);
  
  //adc->setAveraging(32, ADC_1); // set number of averages
  adc->setResolution(16, ADC_1); // set bits of resolution
  adc->setConversionSpeed(ADC_VERY_HIGH_SPEED, ADC_1); // change the conversion speed
  adc->setSamplingSpeed(ADC_HIGH_SPEED, ADC_1); // change the sampling speed
  adc->setReference(ADC_REF_3V3, ADC_1);

  //Serial.begin(230400);
  Serial.begin(115200);
  unsigned short adc0_value;
  unsigned short adc1_value;
  ADC::Sync_result  adc_messwert;
  char messungen[65];
  signed int adc_value[32];
  signed int calibration[32] = {};
  bool MIDI_aktiviert = true;
  bool MIDI_play[32] = {};
  signed long integral2D[255][32] = {};
  signed long integralwert[32] = {};
  unsigned char integralcounter[32] = {};
  
  unsigned char messung = 0;
  unsigned char hhigh;
  unsigned char saite;
  //delayMicroseconds(1);

  messen:
  {
    messungen[0] = Syncbyte; //Sync
    hhigh = 128;
    messung=1;
    saite=0;

    unsigned char siebzehner[16];
    for (unsigned char i=0; i < 15; ++i) siebzehner[i]=17*(i+1);
    siebzehner[15]=0;
    
    for (unsigned char i=0; i < 16; ++i){
      adc_messwert = adc->analogSyncRead(A5, A2);
      PORTD = siebzehner[i];
      adc0_value = (unsigned short)adc_messwert.result_adc0 >> 1; //adc->analogRead(A5, ADC_0) >> 1;
      adc1_value = (unsigned short)adc_messwert.result_adc1 >> 1; //adc->analogRead(A2, ADC_1) >> 1;

      if (MIDI_aktiviert == false) {
        messungen[messung++] = (char)(hhigh + (adc0_value >> 8)); hhigh=0; //high
        messungen[messung++] = (char)adc0_value; //low
        messungen[messung++] = (char)(adc1_value >> 8); //high
        messungen[messung++] = (char)adc1_value; //low
      } else {
        adc_value[saite]=adc0_value;
        adc_value[saite+16]=adc1_value;
        for (int i=saite; i <= saite+16; i += 16) {
          if (adc_value[i]+calibration[i] > 16383) --calibration[i]; else ++calibration[i];
          adc_value[i] += calibration[i] - 16383;
          //Serial.println(adc_value[i]);
          integralwert[i] += adc_value[i] - integral2D[integralcounter[i]][i]; //Fehler!!!
          Serial.println(integralwert[i]);
          continue;
          integral2D[integralcounter[i]][i]=adc_value[i];
          integralcounter[i]++;
          continue;
          if(MIDI_play[i]) {
            if(integralwert[i] < 100000) {
              usbMIDI.sendNoteOff(i + 45, 100, 1);
              MIDI_play[i] = false;
            }
          } else {
            if(integralwert[saite] > 1100000) {
              usbMIDI.sendNoteOn(i + 45, 100, 1);
              MIDI_play[i] = true;
            }
          }
        }
        ++saite;
        
      }

    }
    if (MIDI_aktiviert == false) {
      Serial.write(messungen, 65);
    }
  }
  goto messen;
}

