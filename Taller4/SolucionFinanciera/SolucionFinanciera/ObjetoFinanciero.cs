
namespace SolucionFinanciera {
    //***********************************************
    //***********************************************
    //***********************************************
    public class ObjetoFinanciero {
        //Atributos de instancia
        private long numeroCuenta;
        private double saldo;

        public string NombreCliente { get; set; }

        public long NumeroCuenta {
            get => numeroCuenta;
            set => numeroCuenta = value;
        }

        public double Saldo {
            get => saldo;
            set => saldo = value;
        }

        public bool EsActivo { get; set; }


        //Constructores
        public ObjetoFinanciero() {
        }

        public ObjetoFinanciero(string nombreCliente, long numeroCuenta, double saldo, bool esActivo) {
            NombreCliente = nombreCliente;
            NumeroCuenta = numeroCuenta;
            Saldo = saldo;
            EsActivo = esActivo;
        }
    }

    
}