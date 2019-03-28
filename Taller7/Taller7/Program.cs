using System;
using Taller7.Controllers;

namespace Taller7 {
class Program {
    private static bool _answer;
    private static Cuadrado _controladorCuadrado;
    private static Rectangulo _controladorRectangulo;
    private static Circulo _controladorCirculo;


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

            else if (exercise == 2) {
                Console.Clear();
                Console.WriteLine("Por favor ingresa el nombre del rectangulo :");
                var nombre = (Console.ReadLine());
                Console.WriteLine("Por favor ingresa la altura :");
                var largo = double.Parse(Console.ReadLine());
                Console.WriteLine("Por favor ingresa la base :");
                var ancho = double.Parse(Console.ReadLine());
                Console.WriteLine("Por favor ingresa su color:");
                var color = Console.ReadLine();
                Console.Clear();
                _controladorRectangulo = new Rectangulo(ancho, largo, nombre, color, "Rectangulo");
                Console.WriteLine("Tipo de la figura : " + _controladorRectangulo.Tipo);
                Console.WriteLine("Nombre de la figura : " + _controladorRectangulo.Nombre);
                Console.WriteLine("Color de la figura : " + _controladorRectangulo.Color);
                Console.WriteLine("El area de tu figura es : " + _controladorRectangulo.ObtenerArea());
                Console.WriteLine("El perimetro de tu figura es : " + _controladorRectangulo.ObtenerPerimetro());
                Console.WriteLine("La diagonal de tu figura es : " + _controladorRectangulo.ObtenerDiagonal());
                Console.WriteLine("Es un rectangulo cuadrado " + _controladorRectangulo.determinarSiEsCuadrado());
            }


            else if (exercise == 3) {
                Console.Clear();
                Console.WriteLine("Por favor ingresa el nombre del Circulo :");
                var nombre = (Console.ReadLine());
                Console.WriteLine("Por favor ingresa la altura :");
                var largo = double.Parse(Console.ReadLine());
                Console.WriteLine("Por favor ingresa su color:");
                var color = Console.ReadLine();
                Console.WriteLine("Por favor ingresa el radio:");
                var radio = (double.Parse(Console.ReadLine()));
                Console.Clear();
                _controladorCirculo = new Circulo(radio, nombre, color, "Cirulo");
                Console.WriteLine("Tipo de la figura : " + _controladorCirculo.Tipo);
                Console.WriteLine("Nombre de la figura : " + _controladorCirculo.Nombre);
                Console.WriteLine("Color de la figura : " + _controladorCirculo.Color);
                Console.WriteLine("El area de tu figura es : " + _controladorCirculo.ObtenerArea());
                Console.WriteLine("El perimetro de tu figura es : " + _controladorCirculo.ObtenerPerimetro());
                Console.WriteLine("El diametro de tu figura es " + _controladorCirculo.ObtenerDiametro());
                Console.WriteLine("La circunferencia de tu figura es : " + _controladorCirculo.ObtenerCircunferencia());
                ;
            }
        } while (_answer == false);
    }
}
}