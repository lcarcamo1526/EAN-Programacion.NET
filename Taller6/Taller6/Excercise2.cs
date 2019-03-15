using System;

namespace Taller6 {
    public class Excercise2 {
        private string text1, text2;


        public void Ex2() {
            Console.WriteLine("Please enter your text1");
            text1 = Console.ReadLine();
            Console.WriteLine("Please enter your text2");

            CheckPalindrome(text1, text2);
        }

        private void CheckPalindrome(string text1, string text2) {
            if (text1.Length != text2.Length) {
                Console.WriteLine("The text has not the same length, please enter a text with the same length");
            }
            else if (text1.Length == text2.Length) {
                var len = 0;
                for (var i = 0; i < text1.Length; i++) {
                    for (var j = text2.Length - 1; i >= 0; i--) {
                        if (i == j) {
                            len++;
                        }
                    }
                }

                Console.WriteLine(len == text1.Length
                    ? "Congrats both words are palindrome "
                    : "Sorry the words are not palindrome");
            }
        }
    }
}