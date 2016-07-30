
#define PI 3.14159265358979
#define PortA 0
#define PortB 1
#define PortC 2
#define PortD 3
#define ADC0 0
#define ADC1 1
#define ADC2 2
#define ADC3 3
#define ADC4 4
#define ADC5 5
#define ADC6 6
#define ADC7 7

//byte Buffer[160];

byte i;
//byte A;
//byte B;
//byte C;
//byte D;

void main(void)
{
    SPI_Disable();
    //word ADC_value;

    //Init RS232: 19200 bps, 8 Bit, 1 Stop, NP
    //Serial_Init_IRQ(0,Buffer,80,80,SR_8BIT|SR_1STOP|SR_NO_PAR,SR_BD230400);
    Serial_Init(0,SR_8BIT|SR_1STOP|SR_NO_PAR,SR_BD230400);

    /*
    //Reverenzspannungen für ADC setzen
    //2560mV/1024Bit = 2,5mV/Bit = 5/2
    ADC_Set(ADC_VREF_VCC, ADC0);
    ADC_Set(ADC_VREF_BG, ADC1);
    ADC_Set(ADC_VREF_BG, ADC2);


    ADC_Set(ADC_VREF_VCC, ADC3);
    ADC_Set(ADC_VREF_VCC, ADC4);
    ADC_Set(ADC_VREF_VCC, ADC5);
    ADC_Set(ADC_VREF_VCC, ADC6);
    ADC_Set(ADC_VREF_VCC, ADC7);
    */

    Port_DataDir(PortC,255);       // PortC auf Ausgang setzen


    Messen:
            Serial_Write(0,250);

            for(i=0;i<16;i++)
            {
                Port_Write(PortC,i);

                ADC_Set(ADC_VREF_VCC, 0);
                Serial_Write(0,ADC_Read()>>2);

                ADC_Set(ADC_VREF_VCC, 1);
                Serial_Write(0,ADC_Read()>>2);
            }

            ADC_Set(ADC_VREF_VCC, 2);
            Serial_Write(0,ADC_Read()>>2);

            ADC_Set(ADC_VREF_VCC, 3);
            Serial_Write(0,ADC_Read()>>2);

            ADC_Set(ADC_VREF_VCC, 4);
            Serial_Write(0,ADC_Read()>>2);

            ADC_Set(ADC_VREF_VCC, 5);
            Serial_Write(0,ADC_Read()>>2);
            AbsDelay(2);
    goto Messen;
}