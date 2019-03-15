using System;
using System.Linq;

namespace Taller6 {
    public class Excercise2 {
        private string text1, text2;


        public void Ex2() {
            Console.Clear();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Please enter your text1");
            text1 = Console.ReadLine();
            Console.WriteLine("Please enter your text2");
            text2 = Console.ReadLine();

            CheckPalindrome(text1, text2);
        }

        private void CheckPalindrome(string text1, string text2) {
            var result = text1.ToCharArray()
                .SequenceEqual(text2.ToCharArray()
                    .Reverse());

            Console.WriteLine(result
                ? "Congrats both words are palindrome "
                : "Sorry the words are not palindrome");
        }
    }
}