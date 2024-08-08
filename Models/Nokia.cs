using System;
namespace DesafioPOO.models;

public class Nokia : Smartphone
{
    public Nokia(string modelo, string marca, string numero) 
        : base(modelo, marca, numero) { }

    public override void InstalarAplicativo(string nomeApp)
    {
        Console.WriteLine($"Instalando aplicativo {nomeApp} no Nokia.");
    }
}
