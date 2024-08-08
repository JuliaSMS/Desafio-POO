using System;

namespace DesafioPOO.models;

public class Program
{
    public static void Main()
    {
        // Instanciando Nokia
        var nokia = new Nokia("3310", "Nokia", "123456789");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        // Instanciando iPhone
        var iphone = new iPhone("iPhone 13", "Apple", "987654321");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
