using System;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            Coder coder = new Coder();
            coder.FillDictionary();
//            Console.WriteLine(coder.letter[' ']);
//            Console.WriteLine(coder.nums[1]);
            var text1 = coder.ConvertTextToNum("casa");
            coder.selectedLetter = 'l';
            var text2 = coder.FormatText(text1);
        }
    }
}