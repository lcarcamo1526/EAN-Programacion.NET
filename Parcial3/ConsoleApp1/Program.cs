using System;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            Coder coder = new Coder();
            coder.FillDictionary();
            coder.SelectedLetterCoder = coder.SelectedLetterDecoder ='m';

            var text3 = coder.Encode("Amnsterdan");
            var text4 = coder.Decode(text3);
            Console.WriteLine(text4);



        }
        
    }
}