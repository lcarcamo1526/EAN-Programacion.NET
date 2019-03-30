using System.Collections.Generic;
using Taller7.Controllers;

namespace Taller7.Modelo {
    public class Suajini : Idioma {
        Dictionary<string, string> keywords = new Dictionary<string, string>();

        /// <summary>
        /// Rellena el diccionario con informacion
        /// </summary>
        public void FillDictionary() {
            keywords.Add("bonito dia", "nice siku");
            keywords.Add("hasta luego", "kuona baadaye");
            keywords.Add("hola", "hujambo");
            keywords.Add("loco", "mambo");
            keywords.Add("salud", "afya");
        }

        /// <summary>
        /// traduce la frase a idioma suajini
        /// </summary>
        /// <param name="frase">frase original</param>
        /// <returns>frase</returns>
        public string traducir(string frase) {
            return keywords[frase.ToLower()] ?? "frase no encontrada";

        }
    }
}