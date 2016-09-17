//#include <MIDI.h>
#include "ADC.h"

void setup() {
  // put your setup code here, to run once:
  DDRD = B11111111;  // sets Arduino Port D to output
  pinMode(13, OUTPUT);
  digitalWrite(13, HIGH);   // turn the LED on (HIGH is the voltage level)

  ADC *adc = new ADC(); // adc object

  pinMode(A5, INPUT); //Diff Channel 0 Positive
  pinMode(A2, INPUT); //Diff Channel 0 Negative
  
  //adc->setAveraging(32, ADC_0); // set number of averages
  adc->setResolution(16, ADC_0); // set bits of resolution
  adc->setConversionSpeed(ADC_HIGH_SPEED, ADC_0); // change the conversion speed
  adc->setSamplingSpeed(ADC_HIGH_SPEED, ADC_0); // change the sampling speed
  adc->setReference(ADC_REF_3V3, ADC_0);
  //adc->enablePGA(64,ADC_0);
  
  //adc->setAveraging(32, ADC_1); // set number of averages
  adc->setResolution(16, ADC_1); // set bits of resolution
  adc->setConversionSpeed(ADC_HIGH_SPEED, ADC_1); // change the conversion speed
  adc->setSamplingSpeed(ADC_HIGH_SPEED, ADC_1); // change the sampling speed
  adc->setReference(ADC_REF_3V3, ADC_1);

  Serial.begin(230400);
  char Sync = B10000000;
  int adc0_value;
  int adc1_value;
  while(true)
  {
    PORTD = 240; //=B11110000
    delayMicroseconds(13);
    Serial.print(Sync); //high
    adc0_value = adc->analogRead(A5, ADC_0) >> 1;
    adc1_value = adc->analogRead(A2, ADC_1) >> 1;
    //Serial.println(adc0_value); //value
    Serial.print((char)(128 + (adc0_value >> 8))); //high
    Serial.print((char)adc0_value); //low
    //Serial.println(adc1_value); //value
    Serial.print((char)(adc1_value >> 8)); //high
    Serial.print((char)adc1_value); //low

    for (int i=241; i <= 255; i++){ //i=B11110001; i <= B11111111
      PORTD = i;
      delayMicroseconds(13);
      //delay(10);
      adc0_value = adc->analogRead(A5, ADC_0) >> 1;
      adc1_value = adc->analogRead(A2, ADC_1) >> 1;
      Serial.print((char)(adc0_value >> 8)); //high
      Serial.print((char)(adc0_value)); //low
      Serial.print((char)(adc1_value >> 8)); //high
      Serial.print((char)(adc1_value)); //low
    }
  }
}

void loop() {
  digitalWrite(13, LOW);    // turn the LED off by making the voltage LOW
  delay(250);                       // wait for a second
  digitalWrite(13, HIGH);   // turn the LED on (HIGH is the voltage level)
  delay(250); 
}

