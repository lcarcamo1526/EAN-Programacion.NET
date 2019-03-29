namespace Taller8.Controller {
public interface interfaceConversionMonedas {
    double CalcularConversionMoneda(bool sentido, double tasa);
    double CalcularConversionBitcoin(string origen, double valor, double tasa);
}
}