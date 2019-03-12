using System;
using System.Collections.Generic;
using System.Linq;
using static System.Convert;

namespace Taller5 {
    public class AgeManager {
        private static bool _answer;
        static List<int> _peoplesAges = new List<int>();

        public void CheckAge() {
            Console.Clear();
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("Hello there!, do you wanna add someone peoples age?'");
            while (_answer == false) {
                Console.WriteLine("Please enter the peoples age ");
                _peoplesAges.Add(ToInt32(Console.ReadLine()));
                Console.WriteLine("Do you wanna keep adding ages?, Please answer 'Yes' or 'no'");
                var secondAnswer = Console.ReadLine()?.ToLower();
                _answer = secondAnswer == "no";
            }

            Console.Clear();
            Console.WriteLine("Here is the youngest guy " + _peoplesAges.Min());
            Console.WriteLine("Here is the older grandpa " + _peoplesAges.Max());
            Console.WriteLine("Here is the average age " + _peoplesAges.Average());
            Console.WriteLine("Age list ordered from older to youngest \n");
            var ordenedAges = _peoplesAges.OrderByDescending(x => x);
            ordenedAges.ToList().ForEach(Console.WriteLine);
          
        }
    }
}