using System;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            Coder coder = new Coder();
            coder.FillDictionary();
            coder.SelectedLetterCoder = coder.SelectedLetterDecoder ='m';

         
            var text1 = coder.ConvertTextToNum("paol");
            var text2 = coder.FormatText(text1);
            var text3 = coder.ClearOutput(text2);
            var tex4 = coder.TryDecodeAll(text3);



            //coder.TryDecodeAll(text2);



        }
        
    }
}