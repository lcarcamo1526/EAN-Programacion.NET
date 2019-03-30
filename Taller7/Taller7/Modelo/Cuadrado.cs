using System;

namespace Taller7.Controllers {
public class Cuadrado : Figura {
    public double Lado { get; private set; }


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
        return Math.Pow(Lado, 2);
    }

    /// <summary>
    /// Return perimetro
    /// </summary>
    /// <returns>perimetro</returns>
    public override double ObtenerPerimetro() {
        return Lado * 4;
    }

    /// <summary>
    /// Return diagonal
    /// </summary>
    /// <returns>diagonal</returns>
    public double ObtenerDiagonal() {
        return Math.Sqrt((Math.Pow(Lado, 2) + Math.Pow(Lado, 2)));
    }


    public Cuadrado(double lado, string nombre = null, string color = null, string tipo = null) : base(nombre, color,
        tipo) {
        Lado = lado;
    }
}
}