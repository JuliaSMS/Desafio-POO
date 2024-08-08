using System;
namespace DesafioPOO.models;

public abstract class Smartphone
{
    public string Modelo { get; set; }
    public string Marca { get; set; }
    public string Numero { get; set; }

    protected Smartphone(string modelo, string marca, string numero)
    {
        Modelo = modelo;
        Marca = marca;
        Numero = numero;
    }

    public abstract void InstalarAplicativo(string nomeApp);

    public void Ligar()
    {
        Console.WriteLine("Ligando...");
    }

    public void ReceberLigacao()
    {
        Console.WriteLine("Recebendo ligação...");
    }
}
