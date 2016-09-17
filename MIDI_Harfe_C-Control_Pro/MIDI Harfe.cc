
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
    //SPI_Disable();

    //data=0x42;
    byte DAT[8] = {0x8C,0xCC,0x9C,0xDC,0xAC,0xEC,0xBC,0xFC};
    byte Adval_High, Adval_Low;



    I2C_Init(I2C_100kHz );
    AbsDelay(1000);
    // write data to 24C64 (8k x 8) EEPROM
    I2C_Start();
    I2C_Write(0x90);         // DEVICE ADDRESS : 0x90
    I2C_Write(0xFC);         // write Data
    I2C_Stop();
    AbsDelay(1);             // delay for applaying configurations
    I2C_Start();
    I2C_Write(0x91);
    Adval_High=I2C_Read_NACK();
    Adval_Low=I2C_Read_NACK();
    I2C_Stop();
    Msg_WriteInt(Adval_High);
    Msg_WriteChar(13);
    Msg_WriteInt(Adval_Low);
}
