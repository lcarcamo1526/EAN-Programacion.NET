using System;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            Coder coder = new Coder();
            coder.FillDictionary();
         
            var text1 = coder.ConvertTextToNum("mona");
            coder.selectedLetterCoder = 'm';
            var text2 = coder.FormatText(text1);
            //var text3 = coder.ClearTextOutput(text2);
            var text3 = coder.CastNumToText(text2);
                
            var text4 = coder.ClearTextInput(text3);
            coder.selectedLetterDecoder = coder.selectedLetterCoder;
            Console.WriteLine(coder.ConvertNumToText(text4));
        }
    }
}