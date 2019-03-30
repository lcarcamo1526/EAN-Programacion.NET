using System.Collections.Generic;
using Taller7.Controllers;

namespace Taller7.Modelo {
    public class Ingles : Idioma {
        Dictionary<string, string> keywords = new Dictionary<string, string>();

        /// <summary>
        /// Rellena el diccionario con informacion
        /// </summary>
        public void FillDictionary() {
            keywords.Add("bonito dia", "nice day");
            keywords.Add("hasta luego", "see you later");
            keywords.Add("hola", "hello");
            keywords.Add("loco", "crazy");
            keywords.Add("salud", "health");
        }

        /// <summary>
        /// traduce la frase a idioma ingles
        /// </summary>
        /// <param name="frase">frase original</param>
        /// <returns>frase</returns>
        public string traducir(string frase) {
          return keywords[frase.ToLower()] ?? "frase no encontrada";
        }
    }
}