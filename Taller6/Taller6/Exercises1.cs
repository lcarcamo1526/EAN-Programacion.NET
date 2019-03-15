using System;


namespace Taller6 {
    public class Exercises1 {
        private string a, b, c;

        public void Ex1() {
            Console.WriteLine("Please enter the first value ");
            a = Console.ReadLine();
            Console.WriteLine("Please enter the second value ");
            b = Console.ReadLine();
            Console.WriteLine("Please enter the third value ");
            c = Console.ReadLine();


            Console.Clear();

            CastVariables(a);
            CastVariables(b);
            CastVariables(c);
        }

        /// <summary>
        /// print out using format
        /// </summary>
        /// <param name="a">number</param>
        private void CastVariables(string a) {
            string s = "Int:{0}, Double:{1}, Long:{2}";
            string msg = string.Format(s, CastVariable(a), CastVariableDouble(a), CastVariableLong(a));

            Console.WriteLine(msg);
        }


        private int CastVariable(string a) {
            int.TryParse(a, out var b);
            if (b is 0)
                Console.WriteLine("Int can not be converted");

            return b;
        }

        private long CastVariableLong(string a) {
            long.TryParse(a, out var b);
            if (b is 0)
                Console.WriteLine("Long can not be converted");
            return b;
        }

        private double CastVariableDouble(string a) {
            double.TryParse(a, out var b);
            if (b is 0)
                Console.WriteLine("Double can not be converted");
            return b;
        }
    }
}