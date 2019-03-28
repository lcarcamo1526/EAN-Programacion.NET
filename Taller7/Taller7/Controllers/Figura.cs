using System;

namespace Taller7.Controllers {
public class Figura {
    private string _nombre;
    private string _color;
    private string _tipo;
    private double _area;
    private double _perimetro;


    public virtual double ObtenerArea() {
        return 0;
    }

    public virtual double ObtenerPerimetro() {
        return 0;
    }

    public override string ToString() {
        return base.ToString();
    }


    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="nombre">Name</param>
    /// <param name="color">Color</param>
    /// <param name="tipo">Type</param>
    /// <param name="area">Area</param>
    /// <param name="perimetro">perimetro</param>
    public Figura(string nombre, string color, string tipo) {
        _nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
        _color = color ?? throw new ArgumentNullException(nameof(color));
        _tipo = tipo ?? throw new ArgumentNullException(nameof(tipo));
    }
}
}