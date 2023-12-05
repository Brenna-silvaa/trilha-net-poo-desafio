using DesafioPOO.Models;


Smartphone nokia = new Nokia(numero: "123456", modelo: "modelo 1", imei: "222222", memoria: 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("Teste nokia finalizado \n");


Smartphone iphone = new Iphone(numero: "22122122", modelo: "modelo 2", imei: "321123", memoria: 574);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Youtube");

Console.WriteLine("Teste iphone finalizado");
