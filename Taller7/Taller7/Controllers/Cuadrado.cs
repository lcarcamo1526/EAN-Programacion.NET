using System;

namespace Taller7.Controllers {
public class Cuadrado : Figura {
    private double _lado;


    /// <inheritdoc />
    /// <summary>
    /// Simple Constructor
    /// </summary>
    /// <param name="nombre">Nombre</param>
    /// <param name="color">Color</param>
    /// <param name="tipo">Tipo</param>
    /// <summary>
    /// Return area 
    /// </summary>
    /// <returns>Area</returns>
    public override double ObtenerArea() {
        return Math.Pow(_lado, 2);
    }

    /// <summary>
    /// Return perimetro
    /// </summary>
    /// <returns>perimetro</returns>
    public override double ObtenerPerimetro() {
        return _lado * 4;
    }

    /// <summary>
    /// Return diagonal
    /// </summary>
    /// <returns>diagonal</returns>
    public double ObtenerDiagonal() {
        return Math.Sqrt((Math.Pow(_lado, 2) + Math.Pow(_lado, 2)));
    }


    public Cuadrado(double lado, string nombre = null, string color = null, string tipo = null, double area = 0,
        double perimetro = 0) : base(nombre, color, tipo, area, perimetro) {
        _lado = lado;
        tipo = "Cuadrado";
    }
}
}