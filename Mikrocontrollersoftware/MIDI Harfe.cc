
#define PI 3.14159265358979
#define ADC0 0
#define ADC1 1
#define ADC2 2
#define ADC3 3
#define ADC4 4
#define ADC5 5
#define ADC6 6
#define ADC7 7

byte Buffer[160];
char str[80];

int i;
int i_Codieren;

//Annahme: Nie mehr als 29 Eingänge! +1 wegen Stringabschlusszeichen!

//byte Anz_ADC;
//char ADC_send[37];

//byte ADC_counter;


word ADC;
byte Cod_Zaehler;

byte A;
byte B;
byte C;
byte D;

byte Start_Port;



void main(void)
{

    //word Limit;

    word ADC_value;
    SPI_Disable();

    //Init RS232: 19200 bps, 8 Bit, 1 Stop, NP
    //Serial_Init_IRQ(0,Buffer,80,80,SR_8BIT|SR_1STOP|SR_NO_PAR,SR_BD230400);
    Serial_Init(0,SR_8BIT|SR_1STOP|SR_NO_PAR,SR_BD230400);

    Port_DataDirBit(PORT_LED1,PORT_OUT);    // Set LED1 PORT to output
    Port_DataDirBit(PORT_LED2,PORT_OUT);    // Set LED2 PORT to output
    Port_WriteBit(PORT_LED1,PORT_OFF);      // Turn LED1 off
    Port_WriteBit(PORT_LED2,PORT_OFF);      // Turn LED2 off


    Port_DataDirBit(18,PORT_OUT);           // PortC.2 auf Ausgang setzen
    Port_DataDirBit(19,PORT_OUT);           // PortC.3 auf Ausgang setzen

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

    Port_DataDirBit(12,PORT_OUT);           // PortC.2 auf Ausgang setzen
    Port_DataDirBit(13,PORT_OUT);           // PortC.3 auf Ausgang setzen
    Port_DataDirBit(14,PORT_OUT);           // PortC.2 auf Ausgang setzen
    Port_DataDirBit(15,PORT_OUT);           // PortC.3 auf Ausgang setzen

    Port_DataDirBit(20,PORT_OUT);           // PortC.2 auf Ausgang setzen
    Port_DataDirBit(21,PORT_OUT);           // PortC.3 auf Ausgang setzen
    Port_DataDirBit(22,PORT_OUT);           // PortC.2 auf Ausgang setzen
    Port_DataDirBit(23,PORT_OUT);           // PortC.3 auf Ausgang setzen


    Messen:

            Serial_Write(0,250);

            for(D=0;D<2;D++)
            {
                Port_WriteBit(23,D);
                for(C=0;C<2;C++)
                {
                    Port_Write(1,C);
                    for(B=0;B<2;B++)
                    {
                        Port_Write(2,B);
                        for(A=0;A<2;A++)
                        {
                            Port_Write(3,A);

                            ADC_Set(ADC_VREF_VCC, 0);
                            Serial_Write(0,ADC_ReadInt()>>2);

                            ADC_Set(ADC_VREF_VCC, 1);
                            Serial_Write(0,ADC_ReadInt()>>2);
                        }
                    }
                }
            }


            ADC_Set(ADC_VREF_VCC, 2);
            Serial_Write(0,ADC_ReadInt()>>2);

            ADC_Set(ADC_VREF_VCC, 3);
            Serial_Write(0,ADC_ReadInt()>>2);

            ADC_Set(ADC_VREF_VCC, 4);
            Serial_Write(0,ADC_ReadInt()>>2);

            ADC_Set(ADC_VREF_VCC, 5);
            Serial_Write(0,ADC_ReadInt()>>2);


    goto Messen;

}