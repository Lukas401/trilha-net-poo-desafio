using System.ComponentModel;
using DesafioPOO.Models;


// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone: Nokia");
Smartphone nokia = new Nokia(numero: "71986134942", modelo: "Modelo 10100", imei: 11111111, memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("--------------------------");

Console.WriteLine("Smartphone: Iphone");
Smartphone Iphone = new Iphone (numero: "71986134942", modelo: "Modelo 10100", imei: 11111111, memoria: 64);
Iphone.Ligar();
Iphone.InstalarAplicativo("Whatsapp");

