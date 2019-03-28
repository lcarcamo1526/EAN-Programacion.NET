using System;
using System.ComponentModel;
using Taller8.Model;

namespace Taller8 {
class Program {
    static void Main(string[] args) {
        Moneda dolar = new Moneda("Dolar", 10);
        Console.WriteLine("Input tax");
        var tax = double.Parse(Console.ReadLine());
        Console.WriteLine("Currency value ");
        var value = double.Parse(Console.ReadLine());
        dolar.Valor = value;
        Console.WriteLine("Conversion " + dolar.CalcularConversionMoneda("dolar", "yuan", false, tax));
    }
}
}