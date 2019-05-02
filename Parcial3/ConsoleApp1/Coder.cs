using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1 {
    public class Coder {
        public Dictionary<char, double> Letter = new Dictionary<char, double>();
        public Dictionary<double, char> Nums = new Dictionary<double, char>();
        public char selectedLetterCoder, selectedLetterDecoder;


        /// <summary>
        /// Feed dictionary with init values
        /// </summary>
        public void FillDictionary() {
            var str_letter = "-abcdefghijklmnñopqrstuvwxyz ".ToCharArray();
            for (int i = 0; i < str_letter.Length; i++) {
                Letter.Add(str_letter[i], i);
                Nums.Add(i, str_letter[i]);
            }
        }

        /// <summary>
        /// Convert text to num
        /// </summary>
        /// <param name="text">Text to convert</param>
        /// <returns>Convertion</returns>
        public List<double> ConvertTextToNum(string text) {
            var answer = new List<double>();
            var user_text = text.ToLower().ToCharArray();
            try {
                answer.AddRange(user_text.Select(character => Letter[character]));
            }
            catch (Exception e) {
                Console.WriteLine("The text has not value in the num dictionary");
            }

//            foreach (var elem in answer) {
//                Console.WriteLine(elem);
//            }

            return answer;
        }

        public List<double> FormatText(List<double> code) {
            if (Letter.ContainsKey(selectedLetterCoder)) {
                var answer = new List<double>();
                var codeLetter = Letter[selectedLetterCoder];
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

        /// <summary>
        /// Cast original nums into string
        /// </summary>
        /// <param name="code">Original nums</param>
        /// <returns>Converted string</returns>
        public string CastNumToText(List<Double> code) {
            var answer = "";
            foreach (var num in code) {
                answer += num + "-";
            }

            answer = answer.Remove(answer.Length - 1);
            return answer;
        }


        public string ClearTextOutput(List<Double> code) {
            var answer = "";
            foreach (var num in code) {
                answer += Math.Floor(num) + "-";
            }

            answer = answer.Remove(answer.Length - 1);
            return answer;
        }


        /// <summary>
        /// Convert input text into list of double
        /// </summary>
        /// <param name="text">string </param>
        /// <returns>Converted list of double</returns>
        public List<Double> ClearTextInput(string text) {
            var edited_text = text.Split("-");
            var answer = new List<double>();
            foreach (var elem in edited_text) {
                double.TryParse(elem, out var str_to_double);
                answer.Add(str_to_double);
            }


            return answer;
        }


        /// <summary>
        /// Convert list of double into string
        /// </summary>
        /// <param name="code">List of double</param>
        /// <returns>converted string</returns>
        public string ConvertNumToText(List<Double> code) {
            if (Letter.ContainsKey(selectedLetterDecoder)) {
                var indexLetter = Letter[selectedLetterDecoder];
                var answer = "";
                foreach (var num in code) {
                    var index = 2 * num - indexLetter;
                    if (Nums.ContainsKey(indexLetter)) {
                        answer += Nums[index];
                    }
                }

                return answer;
            }

            return null;
        }
    }
}