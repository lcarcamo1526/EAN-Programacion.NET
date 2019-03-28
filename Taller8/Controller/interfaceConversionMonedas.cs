namespace Taller8.Controller {
public interface interfaceConversionMonedas {
    double CalcularConversionMoneda(string origen, string destino, bool sentido, double tasa);
    double CalcularConversionBitcoinstring(string origen, double valor, double tasa, double tasa_dolar);
}
}