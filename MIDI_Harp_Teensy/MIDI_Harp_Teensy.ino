//#include <MIDI.h>
#include "ADC.h"
#define USBSERIAL Serial       // for Leonardo, Teensy, Fubarino
#define Syncbyte B10000000

void setup() {




}


void loop() {
  
    // put your setup code here, to run once:
  DDRD = B11111111;  // sets Arduino Port D to output
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
  byte messung = 0; 
  /*
  char messungen[] = { 128,
    255, 255, 127, 255, 127, 255, 127, 255, 127, 255,
    127, 255, 127, 255, 127, 255, 127, 255, 127, 255,
    127, 255, 127, 255, 127, 255, 127, 255, 127, 255,
    127, 255, 127, 255, 127, 255, 127, 255, 127, 255,
    127, 255, 127, 255, 127, 255, 127, 255, 127, 255,
    127, 255, 127, 255, 127, 255, 127, 255, 127, 255,
    127, 255, 127, 255};

  String myString = String(myword);
  String largetext = myString + myString + myString + myString + myString +
                     myString + myString + myString + myString + myString;
  while(true)
  {
    Serial.write(myword, 65);
    //USBSERIAL.print(myString);
    
  }
*/
  //PORTD = 0; //=B11110000
  messen:
  {
    messungen[0] = Syncbyte; //Sync
    messung=1;
    PORTD = 0;
    delayMicroseconds(1);
    adc_messwert = adc->analogSyncRead(A5, A2);
    //PORTD = 0;
    adc0_value = (unsigned short)adc_messwert.result_adc0 >> 1; //adc->analogRead(A5, ADC_0) >> 1;
    adc1_value = (unsigned short)adc_messwert.result_adc1 >> 1; //adc->analogRead(A2, ADC_1) >> 1;
    //Serial.println((unsigned short)adc_messwert.result_adc0);
    //Serial.println((unsigned short)adc_messwert.result_adc1);
    //adc0_value = adc->analogRead(A5, ADC_0) >> 1;
    //adc1_value = adc->analogRead(A2, ADC_1) >> 1;
    messungen[messung] = (char)(128 + (adc0_value >> 8)); messung++; //high
    messungen[messung] = (char)adc0_value; messung++; //low
    messungen[messung] = (char)(adc1_value >> 8); messung++; //high
    messungen[messung] = (char)adc1_value; messung++; //low

    //for (int i=242; i < 257; i++){ //15 Messungen B11110001 bis B11111111
    for (int i=17; i <= 255; i+=17){ //i=B11110001; i <= B11111111
      PORTD = i;
      delayMicroseconds(1);
      adc_messwert = adc->analogSyncRead(A5, A2);
      //PORTD = i;
      adc0_value = (unsigned short)adc_messwert.result_adc0 >> 1; //adc->analogRead(A5, ADC_0) >> 1;
      adc1_value = (unsigned short)adc_messwert.result_adc1 >> 1; //adc->analogRead(A2, ADC_1) >> 1;
      //Serial.println(adc0_value);
      //Serial.println(adc1_value);
      //adc0_value = adc->analogRead(A5, ADC_0) >> 1;
      //adc1_value = adc->analogRead(A2, ADC_1) >> 1;
      messungen[messung] = (char)(adc0_value >> 8); messung++; //high
      messungen[messung] = (char)adc0_value; messung++; //low
      messungen[messung] = (char)(adc1_value >> 8); messung++; //high
      messungen[messung] = (char)adc1_value; messung++; //low
    }
    //PORTD = 240; //=B11110000
    Serial.write(messungen, 65);
  }
  goto messen;
}

