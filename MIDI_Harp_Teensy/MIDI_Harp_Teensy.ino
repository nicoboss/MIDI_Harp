//#include <MIDI.h>
#include "ADC.h"
#define USBSERIAL Serial       // for Leonardo, Teensy, Fubarino
#define Syncbyte B10000000


void setup() {
  // put your setup code here, to run once:
  pinMode(13, OUTPUT);
  digitalWrite(13, HIGH);   // turn the LED on (HIGH is the voltage level)
}


void loop() {
  /*
  usbMIDI.sendNoteOn(77, 100, 1);
  delay(250);
  usbMIDI.sendNoteOff(77, 100, 1);
  delay(100);
  */
  DDRD = B11111111;  // sets Arduino Port D to output
  PORTD = 0;
  
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
  ADC::Sync_result adc_messwert;
  char messungen[65];
  signed int adc_value[32] = {};
  signed int calibration[32] = {};
  bool MIDI_aktiviert = false;
  bool MIDI_play[32] = {};
  signed long integral2D[256][32] = {{}};
  signed long integralwert[32] = {};
  unsigned char integralcounter[32] = {};
  unsigned char messung = 0;
  unsigned char hhigh;
  unsigned char saite;
  unsigned char siebzehner[16];
  for (unsigned char i=0; i < 15; ++i) siebzehner[i]=17*(i+1);
  siebzehner[15]=0;

  messen:
  {
    messungen[0] = Syncbyte; //Sync
    hhigh = 128;
    messung=1;
    saite=0;

    if (MIDI_aktiviert) {
      for (unsigned char i=0; i < 16; ++i){
        adc_messwert = adc->analogSyncRead(A5, A2);
        PORTD = siebzehner[i];
        adc_value[saite]=(unsigned short)adc_messwert.result_adc0 >> 1; //adc->analogRead(A5, ADC_0) >> 1;
        adc_value[saite+16]=(unsigned short)adc_messwert.result_adc1 >> 1; //adc->analogRead(A2, ADC_1) >> 1;
        for (int i=saite; i <= saite+16; i += 16) {
          if (adc_value[i]+calibration[i] > 16383) --calibration[i]; else ++calibration[i];
          adc_value[i] = abs(adc_value[i] + calibration[i] - 16383);
          integralwert[i] += adc_value[i] - integral2D[integralcounter[i]][i];
          //Serial.println(integralwert[i]);
          //Serial.send_now();
          integral2D[integralcounter[i]++][i]=adc_value[i];
          if(MIDI_play[i]) {
            if(integralwert[i] < 300000) {
              usbMIDI.sendNoteOff(i + 45, 100, 1);
              MIDI_play[i] = false;
            }
          } else {
            if(integralwert[i] > 2000000) {
              usbMIDI.sendNoteOn(i + 45, 100, 1);
              MIDI_play[i] = true;
            }
          }
        }
        ++saite;
      }
    } else {
      for (unsigned char i=0; i < 16; ++i){
        adc_messwert = adc->analogSyncRead(A5, A2);
        PORTD = siebzehner[i];
        adc0_value = (unsigned short)adc_messwert.result_adc0 >> 1; //adc->analogRead(A5, ADC_0) >> 1;
        adc1_value = (unsigned short)adc_messwert.result_adc1 >> 1; //adc->analogRead(A2, ADC_1) >> 1;
        messungen[messung++] = (char)(hhigh + (adc0_value >> 8)); hhigh=0; //high
        messungen[messung++] = (char)adc0_value; //low
        messungen[messung++] = (char)(adc1_value >> 8); //high
        messungen[messung++] = (char)adc1_value; //low
      }
      Serial.write(messungen, 65);
    }
  }
  goto messen;
}
//delayMicroseconds(1);
