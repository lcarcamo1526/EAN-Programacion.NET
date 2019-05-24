using System;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            Coder coder = new Coder();
            coder.FillDictionary();
            coder.SelectedLetterCoder = coder.SelectedLetterDecoder ='a';

            var text3 = coder.Encode("Amnsterdan");
            var text4 = coder.Dec ode("9-1-8-6-1");
            Console.WriteLine(text4);



        }
        
    }
}