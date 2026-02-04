using System;
using System;
using DesafioPOO.Models;

// Demonstração de uso
Console.WriteLine("Smartphone Nokia:");
var nokia = new Nokia(numero: "11 90000-0000", modelo: "Nokia 3310", imei: "123456789012345", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");
nokia.ReceberLigacao();

Console.WriteLine();

Console.WriteLine("Smartphone iPhone:");
var iphone = new Iphone(numero: "11 98888-8888", modelo: "iPhone 14", imei: "987654321098765", memoria: 256);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");
iphone.ReceberLigacao();