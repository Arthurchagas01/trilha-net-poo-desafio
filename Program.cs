using System.ComponentModel;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("952979001", "N95", "112023400199", "64");
nokia.Ligar();
nokia.InstalarAplicativo("Pokemon Go");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("952979001", "15 pro", "458789963267", "128");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("YouTube");