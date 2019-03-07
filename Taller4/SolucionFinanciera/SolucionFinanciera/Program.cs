using System;



namespace SolucionFinanciera {
    class Program {
        //Referencia a la clase de la lógica
        private static LogicaCalculadora calculadora;

        //************************************************
        //************************************************
        //************************************************
        public ObjetoFinanciero leerDatosCliente() {
            ObjetoFinanciero portafolio = new ObjetoFinanciero();

            portafolio.NombreCliente = leerCadena("Ingrese el nombre del cliente: ");
            portafolio.NumeroCuenta = long.Parse(leerCadena("Ingrese el numero de cuenta del cliente: "));
            portafolio.Saldo = leerValorReal("Ingrese el valor del saldo original del cuentahabiente: ");
            portafolio.EsActivo = true;

            return (portafolio);
        }
        //************************************************
        //************************************************
        //************************************************

        public double leerValorReal(string mensaje) {
            Console.WriteLine(mensaje);
            return double.Parse(Console.ReadLine());
        }

        public string leerCadena(string mensaje) {
            Console.WriteLine(mensaje);
            return Console.ReadLine();
        }

        //************************************************
        //************************************************
        //************************************************
        //************************************************
        //Método principal integrador de los objetos de la solución
        static void Main(string[] args) {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkYellow;

            double interesValorSaldo = 0.0;
            double interesCompuesto = 0.0;
            double valorVenta = 0.0;

            Program programaPrincipal = new Program();
            ObjetoFinanciero datosCliente = null;


            //Lectura de los datos
            datosCliente = programaPrincipal.leerDatosCliente();

            calculadora = new LogicaCalculadora();
            calculadora.DatosCliente = datosCliente;

            interesCompuesto =
                programaPrincipal.leerValorReal("Digite el interes compuesto para el saldo del cliente: ");
            valorVenta = programaPrincipal.leerValorReal("Digite el valor de venta del cliente: ");

            //Cálculo de negocio
            interesValorSaldo = calculadora.CalcularValorSaldo(interesCompuesto, valorVenta);

            Console.WriteLine("************************************");
            Console.WriteLine("************************************");

            Console.WriteLine("Nombre cliente {0} - Numero cuenta {1}",
                datosCliente.NombreCliente, datosCliente.NumeroCuenta);

            Console.WriteLine("Valor del interes del saldo: " + interesValorSaldo +
                              " sobre la base de interes compuesto: " + interesCompuesto +
                              " y valor de venta de " + valorVenta);

            Console.WriteLine("************************************");
            Console.WriteLine("************************************");
            Console.Write("Pulse una tecla para finalizar");
            Console.ReadKey();
        }

       
    } 
} 