using System.Collections.Generic;
using Taller7.Controllers;

namespace Taller7.Modelo {
    public class Portugues : Idioma {
        Dictionary<string, string> keywords = new Dictionary<string, string>();

        /// <summary>
        /// Rellena el diccionario con informacion
        /// </summary>
        public void FillDictionary() {
            keywords.Add("bonito dia", "bom dia");
            keywords.Add("hasta luego", "até logo");
            keywords.Add("hola", "Olá");
            keywords.Add("loco", "louco");
            keywords.Add("salud", "saúde");
        }

        /// <summary>
        /// traduce la frase a idioma Portugues
        /// </summary>
        /// <param name="frase">frase original</param>
        /// <returns>frase</returns>
        public string traducir(string frase) {
            return keywords[frase.ToLower()] ?? "frase no encontrada";
        }
    }
}