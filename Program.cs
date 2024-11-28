using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Nesta Black Friday compre o Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Nokia X900", imei: "111222333", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Nesta Black Friday compre o Iphone:");
Smartphone iphone = new Iphone(numero: "654321", modelo: "Iphone 12 pro Max", imei: "333222111", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Itunes");