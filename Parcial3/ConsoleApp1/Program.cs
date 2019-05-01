using System;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            Coder coder = new Coder();
            coder.FillDictionary();
         
            var text1 = coder.ConvertTextToNum("casa");
            coder.selectedLetter = 'l';
            var text2 = coder.FormatText(text1);
            var text3 = coder.ClearText(text2);
            Console.WriteLine(text3);
        }
    }
}