using System;

namespace SolucionFinanciera {
    //****************************************************
    //****************************************************
    //****************************************************
    public class LogicaCalculadora {
        public ObjetoFinanciero DatosCliente { get; set; }


        public double CalcularValorSaldo(double interesCompuesto, double valorVenta) {
            double valorSaldo = 0.0;

            if (interesCompuesto != 0 && DatosCliente.Saldo != 0) {
                Console.WriteLine("intereses compuesto: {0} ", interesCompuesto);
                Console.WriteLine("Saldo del cliente: " + DatosCliente.Saldo);

                valorSaldo = Math.Sqrt((interesCompuesto + 3 * valorVenta) / (4 * Math.Pow(interesCompuesto, 3))) /
                             (3 * Math.Pow(interesCompuesto, 8) - 2 * DatosCliente.Saldo);

                Console.WriteLine("Resultado del cálculo: {0}", valorSaldo);
            }
            else {
                valorSaldo = DatosCliente.Saldo;
            }

            return valorSaldo;
        }

        //************************************************************
        //************************************************************
        //************************************************************
        //************************************************************
        public double calcularBonoBeneficio() {
            var bono = 0.0;

            if (DatosCliente.Saldo >= 10000 && DatosCliente.Saldo <= 100000) {
                bono = (DatosCliente.Saldo * 0.20);
            }

            return (bono);
        }
    }
}