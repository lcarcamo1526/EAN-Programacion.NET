using System;

namespace Taller7.Controllers {
public class Rectangulo : Figura {
    private double _ancho, _largo;

    public Rectangulo(string nombre, string color, string tipo) : base(nombre, color, tipo) {
    }


    /// <summary>
    /// Obtiene el area del rectangulo
    /// </summary>
    /// <returns>AREA</returns>
    public override double ObtenerArea() {
        return _ancho * _largo;
    }

    /// <summary>
    /// Obtiene el perimetro del rectangulo
    /// </summary>
    /// <returns>Perimetro</returns>
    public override double ObtenerPerimetro() {
        return (_ancho * 2) + (_largo * 2);
    }


    /// <summary>
    /// Obtiene la diagonal del rectangulo
    /// </summary>
    /// <returns>Diagonal</returns>
    public double ObtenerDiagonal() {
        return Math.Sqrt((Math.Pow(_ancho, 2) + Math.Pow(_largo, 2)));
    }

    /// <summary>
    /// Determina si es cuadrado
    /// </summary>
    /// <returns>True, si es cuadrado, de lo contrario false</returns>
    public bool determinarSiEsCuadrado() {
        return _ancho == _largo;
    }


    public Rectangulo(double ancho, double largo, string nombre = null, string color = null, string tipo = null) : base(
        nombre, color, tipo) {
        _ancho = ancho;
        _largo = largo;
        
    }
}
}