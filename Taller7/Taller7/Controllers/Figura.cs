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


    public Figura(string nombre = null, string color = null, string tipo = null, double area = 0,
        double perimetro = 0) {
        _nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
        _color = color ?? throw new ArgumentNullException(nameof(color));
        _tipo = tipo ?? throw new ArgumentNullException(nameof(tipo));
       
    }
}
}