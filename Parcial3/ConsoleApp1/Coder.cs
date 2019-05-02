using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1 {
    public class Coder {
        public Dictionary<char, double> Letter = new Dictionary<char, double>();
        public Dictionary<double, char> Nums = new Dictionary<double, char>();
        public char SelectedLetterCoder, SelectedLetterDecoder;


        /// <summary>
        /// Feed dictionary with init values
        /// </summary>
        public void FillDictionary() {
            var strLetter = "-abcdefghijklmnñopqrstuvwxyz ".ToCharArray();
            for (int i = 0; i < strLetter.Length; i++) {
                Letter.Add(strLetter[i], i);
                Nums.Add(i, strLetter[i]);
            }
        }

        /// <summary>
        /// Convert text to num
        /// </summary>
        /// <param name="text">Text to convert</param>
        /// <returns>Convertion</returns>
        public List<double> ConvertTextToNum(string text) {
            var answer = new List<double>();
            var userText = text.ToLower().ToCharArray();
            try {
                answer.AddRange(userText.Select(character => Letter[character]));
            }
            catch (Exception e) {
                Console.WriteLine("The text has not value in the num dictionary");
            }

//            foreach (var elem in answer) {
//                Console.WriteLine(elem);
//            }

            return answer;
        }


        /// <summary>
        /// Format nums into modified doubles
        /// </summary>
        /// <param name="code"> Original doubles</param>
        /// <returns>Modified doubles</returns>
        public List<double> FormatText(List<double> code) {
            if (Letter.ContainsKey(SelectedLetterCoder)) {
                var answer = new List<double>();
                var codeLetter = Letter[SelectedLetterCoder];
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


        /// <summary>
        /// Cast a list of double into cleaned string
        /// </summary>
        /// <param name="code">original list</param>
        /// <returns>converted string</returns>
        public string ClearTextOutput(List<Double> code) {
            var answer = "";
            foreach (var num in code) {
                answer += Math.Floor(num) + "-";
            }

            answer = answer.Remove(answer.Length - 1);
            return answer;
        }


        public List<Double> ClearOutput(List<Double> code) {
            var copy = code;
            for (int i = 0; i < copy.Count; i++) {
                copy[i] = Math.Floor(copy[i]);
//                Console.WriteLine(copy[i]);
            }

            return copy;
        }


        /// <summary>
        /// Convert input text into list of double
        /// </summary>
        /// <param name="text">string </param>
        /// <returns>Converted list of double</returns>
        public List<Double> ClearTextInput(string text) {
            var editedText = text.Trim().Split("-");
            var answer = new List<double>();
            foreach (var elem in editedText) {
                double.TryParse(elem, out var strToDouble);
                answer.Add(strToDouble);
                Console.WriteLine(strToDouble);
            }


            return answer;
        }


        /// <summary>
        /// Convert list of double into string
        /// </summary>
        /// <param name="code">List of double</param>
        /// <returns>converted string</returns>
        public string DecodeGeneral(List<Double> code) {
            if (Letter.ContainsKey(SelectedLetterDecoder)) {
                var indexLetter = Letter[SelectedLetterDecoder];
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

        public List<Double> Decode(List<Double> code) {
            if (Letter.ContainsKey(SelectedLetterDecoder)) {
                var indexLetter = Letter[SelectedLetterDecoder];
                List<Double> answer = new List<double>();
                foreach (var num in code) {
                    var index = 2 * num - indexLetter;
                    answer.Add(index);
                }

                return answer;
            }

            return null;
        }


        /// <summary>
        /// Try to decode all decimals according the index letter
        /// </summary>
        /// <param name="code">Original code</param>
        /// <returns>Answer</returns>
        public List<Double> TryDecodeAll(List<Double> code) {
            List<Double> numLetter = new List<double>();
            var indexLetter = Letter[SelectedLetterDecoder];
            var possibleCombination = new List<Double>();
            for (int i = 0; i < Nums.Count; i++) {
                var letterIndex = Nums[i];
                var check = (Letter[letterIndex] + indexLetter) / 2;
                if (check % 1 == 0.5) {
                    possibleCombination.Add(check);
                    Console.WriteLine(check);
                }
            }

            return code;
        }
    }
}