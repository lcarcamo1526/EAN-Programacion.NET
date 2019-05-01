using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleApp1 {
    public class Coder {
        public Dictionary<char, double> Letter = new Dictionary<char, double>();
        public Dictionary<double, char> Nums = new Dictionary<double, char>();
        public char selectedLetter;


        public void FillDictionary() {
            var str_letter = "-abcdefghijklmnñopqrstuvwxyz ".ToCharArray();
            for (int i = 0; i < str_letter.Length; i++) {
                Letter.Add(str_letter[i], i);
                Nums.Add(i, str_letter[i]);
            }
        }


        public List<double> ConvertTextToNum(string text) {
            var answer = new List<double>();
            var user_text = text.ToLower().ToCharArray();
            try {
                answer.AddRange(user_text.Select(character => Letter[character]));
            }
            catch (Exception e) {
                Console.WriteLine("The text has not value in the num dictionary");
            }

            foreach (var elem in answer) {
                Console.WriteLine(elem);
            }

            return answer;
        }

        public List<double> FormatText(List<double> code) {
            if (Letter.ContainsKey(selectedLetter)) {
                var answer = new List<double>();
                var codeLetter = Letter[selectedLetter];
                foreach (var num in code) {
                    answer.Add((num + codeLetter) / 2);
                }
//                foreach (var elem in answer) {
//                    Console.WriteLine(elem);
//                }
                return answer;
            }

            return null;
        }
    }
}