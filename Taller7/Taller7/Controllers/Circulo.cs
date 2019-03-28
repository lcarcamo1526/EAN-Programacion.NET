using System;

namespace Taller7.Controllers {
public class Circulo : Figura {
    private double _radio;


    /// <summary>
    /// Obtiene el perimetro del circulo
    /// </summary>
    /// <returns></returns>
    public override double ObtenerPerimetro() {
        return 2 * Math.PI * _radio;
    }


    /// <summary>
    /// Obtiene el area de la figura
    /// </summary>
    /// <returns></returns>
    public override double ObtenerArea() {
        return Math.PI * Math.Pow(_radio, 2);
    }

    /// <summary>
    /// Obtiene la circunferencia
    /// </summary>
    /// <returns></returns>
    public double ObtenerCircunferencia() {
        return Math.PI * ObtenerDiametro();
    }

    /// <summary>
    /// Obtiene el diametro
    /// </summary>
    /// <returns></returns>
    public double ObtenerDiametro() {
        return _radio * 2;
    }

    public Circulo(double radio, string nombre = null, string color = null, string tipo = null, double area = 0,
        double perimetro = 0) : base(nombre, color, tipo, area, perimetro) {
        _radio = radio;
        tipo = "Circulo";
    }
}
}