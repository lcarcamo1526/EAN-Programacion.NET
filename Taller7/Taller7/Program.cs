using System;
using Taller7.Controllers;

namespace Taller7 {
class Program {
    private static bool _answer;
    private static Cuadrado _controladorCuadrado;


    public static void Main() {
        do {
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("Hola, selecciona la figura que deseas crear\n" +
                              "#1 Cuadrado \n" +
                              "#2 Rectangulo \n" +
                              "#3 Circulo \n " +
                              "#0 Salir \n "
            );

            var exercise = int.Parse(Console.ReadLine());
            if (exercise == 1) {
                Console.Clear();
                Console.WriteLine("Por favor ingresa el nombre del cuadrado :");
                var nombre = (Console.ReadLine());
                Console.WriteLine("Por favor ingresa la longitud de sus lados :");
                var lados = double.Parse(Console.ReadLine());
                Console.WriteLine("Por favor ingresa su color:");
                var color = Console.ReadLine();
                Console.Clear();
                _controladorCuadrado = new Cuadrado(lados, nombre, color, "Cuadrado");
                Console.WriteLine("Tipo de la figura : " + _controladorCuadrado.Tipo);
                Console.WriteLine("Nombre de la figura : " + _controladorCuadrado.Nombre);
                Console.WriteLine("Color de la figura : " + _controladorCuadrado.Color);
                Console.WriteLine("El area de tu figura es : " + _controladorCuadrado.ObtenerArea());
                Console.WriteLine("El perimetro de tu figura es : " + _controladorCuadrado.ObtenerPerimetro());
                Console.WriteLine("La diagonal de tu figura es : " + _controladorCuadrado.ObtenerDiagonal());
            }
        } while (_answer == false);
    }
}
}