using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TallerMVC5.Models
{
    public class Calificaciones
    {
        public string Nombre_Estudiante { get; set; }
        public string Apellido_Estudiante { get; set; }
        public int Nota1 { get; set; }
        public int Nota2 { get; set; }
        public int Nota3 { get; set; }




        public Double DeterminarDefinitiva() {
            if (Nota1 == 0 && Nota2 == 0 && Nota3 == 0)
            {
                return 0;
            }
            else {
                return Math.Abs(Nota1) * 0.3 + Math.Abs(Nota2) * 0.3 + Math.Abs(Nota3) * 0.4;
            }
           
           
            

        }

    }
}
