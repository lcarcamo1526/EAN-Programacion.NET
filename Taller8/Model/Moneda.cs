using Taller8.Controller;

namespace Taller8.Model {
public class Moneda : interfaceConversionMonedas {
    public string Nombre { get; set; }
    public double Valor { get; set; }

    public Moneda(string nombre, double valor) {
        Nombre = nombre;
        Valor = valor;
    }

    public Moneda() {
    }


    public double CalcularConversionMoneda(bool sentido, double tasa) {
        return (sentido) ? Valor * tasa : Valor / tasa;
    }

    public double CalcularConversionBitcoin(string origen, double valor, double tasa) {
        switch (origen) {
            case "dolares":
                return valor * tasa;
            case "euros":
                return valor * 1.12 * tasa;
            case "yuanes":
                return valor * 0.15 * tasa;
            case "yenes":
                return valor * 0.009 * tasa;
            default:
                return valor * 0.00031 * tasa;
        }
    }
}
}