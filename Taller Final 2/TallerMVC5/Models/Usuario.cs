using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TallerMVC5.Models
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Numero_horas { get; set; }
        public int Valor_horas { get; set; }
        public int Riesgo { get; set; }



        public Dictionary<String, double> CalcularSalario() {
            var dict = new Dictionary<String, double>();
            if (Numero_horas == 0 && Valor_horas == 0 && Riesgo == 0)
            {
                dict["riesgo"] = 0;
                dict["salud"] = 0;
                dict["descuentos"] = 0;
                dict["pension"] = 0;
                dict["bruto"] = 0;
                dict["diferencia"] = 0;
                return dict;


            }
            else {
                dict.Add("bruto", Math.Abs(Numero_horas * Valor_horas));
                dict.Add("salud", Math.Abs((dict["bruto"] * 14.5)) / 100);
                dict.Add("pension", Math.Abs((dict["bruto"] * 12.6)) / 100);

                if (Math.Abs(Riesgo) <= 1)
                    dict["riesgo"] = dict["bruto"] * 0.05;
                else if (Math.Abs(Riesgo) == 2)
                    dict["riesgo"] = dict["bruto"] * 0.14;
                else if (Math.Abs(Riesgo) >= 3)
                    dict["riesgo"] = dict["bruto"] * 0.33;

                dict.Add("descuentos", Math.Abs(dict["riesgo"] + dict["pension"] + dict["salud"]));
                dict.Add("diferencia", Math.Abs(dict["bruto"] - dict["descuentos"]));

                return dict;
            }
            






        }


        }
    }

