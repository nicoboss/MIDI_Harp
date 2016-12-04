//#include <MIDI.h>
#include "ADC.h"
#define USBSERIAL Serial       // for Leonardo, Teensy, Fubarino
#define Syncbyte B10000000

void MIDI_send(unsigned short value) {
  delayMicroseconds(1);
}

void setup() {

}


void loop() {
  
  // put your setup code here, to run once:
  DDRD = B11111111;  // sets Arduino Port D to output
  pinMode(13, OUTPUT);
  digitalWrite(13, HIGH);   // turn the LED on (HIGH is the voltage level)
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
  ADC::Sync_result  adc_messwert;
  char messungen[65];
  byte messung = 0;
  int calibration[65] = {}; //nur 1,3,5,7,9,11,...,65 benutzt.
  bool MIDI_out = false;
  //bool MIDI_play[65];
  //byte Notenreihenfolge[65];
  
  messen:
  {
    messungen[0] = Syncbyte; //Sync
    messung=5; //=1
    delayMicroseconds(2);
    adc_messwert = adc->analogSyncRead(A5, A2);
    adc0_value = static_cast<unsigned short>(adc_messwert.result_adc0 >> 1); //adc->analogRead(A5, ADC_0) >> 1;
    adc1_value = static_cast<unsigned short>(adc_messwert.result_adc1 >> 1); //adc->analogRead(A2, ADC_1) >> 1;
    PORTD = 17;
    if (adc0_value+calibration[1] > 16384) --calibration[1]; else ++calibration[1];
    adc0_value += calibration[1];
    if (MIDI_out == true) MIDI_send(adc0_value);
    messungen[1] = static_cast<char>(128 + (adc0_value >> 8)); //high
    messungen[2] = static_cast<char>(adc0_value); //low
    if (adc1_value+calibration[3] > 16384) --calibration[3]; else ++calibration[3];
    adc1_value += calibration[3];
    if (MIDI_out == true) MIDI_send(adc1_value);
    messungen[3] = static_cast<char>(adc1_value >> 8); //high
    messungen[4] = static_cast<char>(adc1_value); //low
    
    for (byte i=17; i > 16; i+=17){ //i=B10001000; i = B11111111   
      delayMicroseconds(2);
      adc_messwert = adc->analogSyncRead(A5, A2);
      adc0_value = static_cast<unsigned short>(adc_messwert.result_adc0 >> 1); //adc->analogRead(A5, ADC_0) >> 1;
      adc1_value = static_cast<unsigned short>(adc_messwert.result_adc1 >> 1); //adc->analogRead(A2, ADC_1) >> 1;
      PORTD = i;
      if (adc0_value+calibration[messung] > 16384) --calibration[messung]; else ++calibration[messung];
      adc0_value += calibration[messung];
      if (MIDI_out == true) MIDI_send(adc0_value);
      messungen[messung] = static_cast<char>(adc0_value >> 8); ++messung; //high
      messungen[messung] = static_cast<char>(adc0_value); ++messung; //low
      if (adc1_value+calibration[messung] > 16384) --calibration[messung]; else ++calibration[messung];
      adc1_value += calibration[messung];
      if (MIDI_out == true) MIDI_send(adc1_value);
      messungen[messung] = static_cast<char>(adc1_value >> 8); ++messung; //high
      messungen[messung] = static_cast<char>(adc1_value); ++messung; //low
    }
    PORTD = 0;
    Serial.write(messungen, 65);
  }
  goto messen;
}

