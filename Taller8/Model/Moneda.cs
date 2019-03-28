using System;
using System.ComponentModel;
using Taller8.Controller;

namespace Taller8.Model {
public class Moneda : interfaceConversionMonedas {
    public string Nombre { get; set; }
    public double Valor { get; set; }

    public Moneda(string nombre, double valor) {
        this.Nombre = nombre;
        this.Valor = valor;
    }

    public Moneda() {
    }


    public double CalcularConversionMoneda(string origen, string destino, bool sentido, double tasa) {
        if (sentido) {
            try {
                if (origen != "dolar" && destino != "") {
                    return Valor * tasa;
                }
            }
            catch (Exception e) {
                Console.WriteLine(e);
                throw new Exception("Por favor ingrese un valor valido");
            }

            return 0;
        }
        else {
            try {
                if (origen == "dolar" && destino != "") {
                    return Valor / tasa;
                }
            }
            catch (Exception e) {
                Console.WriteLine(e);
                throw new Exception("Por favor ingrese un valor valido");
            }
        }

        return 0;
    }

    public double CalcularConversionBitcoinstring(string origen, double valor, double tasa, double tasa_dolar) {
        if (origen != "dolar") {
            var valor_usd = CalcularConversionMoneda("", "dolar", true, tasa_dolar);
            return valor_usd * tasa;
        }
        else {
            return valor * tasa;
        }

        return 0;
    }
}
}