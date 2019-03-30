using System;

namespace Taller7.Controllers {
public class Figura {
    public string Nombre { get; private set; }

    public string Color { get; private set; }

    public string Tipo { get; private set; }

    public double Area { get; private set; }

    public double Perimetro { get; private set; }

    public virtual double ObtenerArea() {
        return 0;
    }

    public virtual double ObtenerPerimetro() {
        return 0;
    }

    public override string ToString() {
        return "" + Nombre + " " + Color + " " + Tipo + " " + Area + " " + Perimetro;
    }


    public Figura(string nombre = null, string color = null, string tipo = null) {
        Nombre = nombre;
        Color = color;
        Tipo = tipo;
    }
}
}