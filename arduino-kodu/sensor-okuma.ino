#include <Wire.h>                   //I2C protokolü için gerekli kütüphane (A4 ve A5 pinleri ayarlı)
#include <MAX30100_PulseOximeter.h> //MAX30100 ile nabız ölçmek için gerekli kütüphane
#include <MAX30100.h>               //Sıcaklık ölçümü için gerekli kütüphane
#include <SoftwareSerial.h>         //Bluetooth bağlantısı için eklediğimiz kütüphane
SoftwareSerial hcBaglanti(7, 6);    //HC 05 modüle bağlantı sağlayacağımız bacakları ayarlıyoruz

#define RaporlamaHizi     1000
uint32_t sonKayit = 0; //Son nabız kaydı zamanını tutacağımız değişken
String data = "49";
int gonderVeri;

MAX30100 sicaklikSensor; //MAX30100'den sicaklikSensor oluşturuyoruz
PulseOximeter nabizSensor; //PulseOximeter'den nabizSensor oluşturuyoruz

void sicaklikYaz(){                                       //Sıcaklık ölçümü için yazılan fonksiyon
  sicaklikSensor.startTemperatureSampling();              // Sıcaklığı ölçmek için MAX30100 kütüphanesinden
  int sicaklik = sicaklikSensor.retrieveTemperature();  // kullanılan fonksiyonlar
  hcBaglanti.print(sicaklik);
  Serial.println(sicaklik);
  hcBaglanti.println("*");
}

void setup(){
  pinMode(10, INPUT); // EKG sensörünün düzgün çalışabilmesi için PO+ ve PO- pinlerini
  pinMode(11, INPUT); // bağladığımız arduinodaki dijital pinleri çıkış olarak ayarlıyoruz

  Serial.begin(9600); //bilgisayar ile olan haberleşmeyi başlatıyoruz
  hcBaglanti.begin(9600); //bluetooth ile olan haberleşmeyi başlatıyoruz

  Serial.println("Başladı");

  nabizSensor.setIRLedCurrent(MAX30100_LED_CURR_7_6MA); //Nabız sensöründeki IR Ledin akımını ayarlıyoruz
}

void loop() {
  if (hcBaglanti.available()){
    data = hcBaglanti.read();
  }

  if(data=="50"){
    if ((digitalRead(10) == 1) || (digitalRead(11) == 1)){   //EKG sensörü düzgün çalışıyor mu kontrol ediyoruz
      //hcBaglanti.println('!');
    }
     else {
      gonderVeri = analogRead(A0);
      hcBaglanti.println(gonderVeri); //EKG sensöründen okunun değerler Seri Çiziciye basıyoruz
      Serial.println(gonderVeri);
    }
    delay(1);
  }
  else{
    nabizSensor.update();
        
    if (millis() - sonKayit > RaporlamaHizi) {    
     hcBaglanti.print((int)nabizSensor.getHeartRate());  // Kalp atış sayısını 
     Serial.println((int)nabizSensor.getHeartRate());           // ve
     hcBaglanti.print("*");
     hcBaglanti.print(nabizSensor.getSpO2());       // Kandaki oksijen miktarını ölçtüğümüz fonksiyonlar
     Serial.println(nabizSensor.getSpO2()); 
     hcBaglanti.print("*");
     sicaklikYaz();
     sonKayit = millis();
   }
  }
}
