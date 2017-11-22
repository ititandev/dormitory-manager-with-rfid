  #include <SPI.h>
  #include <MFRC522.h> // thu vien "RFID".
  const int LED1 = 2; // LED do
  const int LED2 = 3; // LED xanh
  /*
  Ket noi voi Arduino Uno hoac Mega
  ----------------------------------------------------- Nicola Coppola
  * Pin layout should be as follows:
  * Signal     Pin              Pin               Pin
  *            Arduino Uno      Arduino Mega      MFRC522 board
  * ------------------------------------------------------------
  * Reset      9                5                 RST
  * SPI SS     10               53                SDA
  * SPI MOSI   11               51                MOSI
  * SPI MISO   12               50                MISO
  * SPI SCK    13               52                SCK
  
  */


  #define SS_PIN 10
  #define RST_PIN 9

  MFRC522 mfrc522(SS_PIN, RST_PIN);       
  unsigned long uidDec, uidDecTemp; // hien thi so UID dang thap phan
  byte bCounter, readBit;
  unsigned long ticketNumber;


  void setup() {
    pinMode(LED1, OUTPUT);
    pinMode(LED2, OUTPUT);
    Serial.begin(9600);     
    SPI.begin();            
    mfrc522.PCD_Init();     
    Serial.println("Waiting for card...");
  }

  void loop() {
    // Tim the moi
    if ( ! mfrc522.PICC_IsNewCardPresent()) {
      return;
    }

    // Doc the
    if ( ! mfrc522.PICC_ReadCardSerial()) {
      return;
    }

    uidDec = 0;

    // Hien thi so UID cua the
    for (byte i = 0; i < mfrc522.uid.size; i++) {
      uidDecTemp = mfrc522.uid.uidByte[i];
      uidDec = uidDec*256+uidDecTemp;
    } 
    Serial.print("[");
    Serial.print(uidDec);

    //--------------------------------
    
    Serial.print("]");



    // Halt PICC
    mfrc522.PICC_HaltA();                       

  }

