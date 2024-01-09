using System.ComponentModel;
using Desafio_POO.Models;

Console.WriteLine("Smartphone: Nokia ");
Smartphone nokia = new Nokia(numero: "12456", modelo: "X2-00", imei: "11111", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Youtube");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "654321", modelo: "iPhone 12", imei: "22222", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Fortnite");