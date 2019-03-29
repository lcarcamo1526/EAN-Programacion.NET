using System;
using System.ComponentModel;
using Taller8.Model;

namespace Taller8 {
class Program {
    static void Main(string[] args) {
        Console.WriteLine("Please enter tax ");
        var tax = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter origin value");
        var origin = double.Parse(Console.ReadLine());
        Moneda dolar = new Moneda("dolar", 4500);
        Console.WriteLine(dolar.CalcularConversionMoneda(true, 200));
        Console.WriteLine(dolar.CalcularConversionBitcoin("", dolar.CalcularConversionMoneda(true, 200), 0.00025));
    }
}
}