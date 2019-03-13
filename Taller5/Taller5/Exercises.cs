using System;

namespace Taller5 {
    public class Exercises {
        private static bool _answer;

        public static void Main() {
            do {
                Console.WriteLine("----------------------------------------------------------------------");
                Console.WriteLine("Hello, please enter the number of the exercise that you want run \n" +
                                  "#1 for Exercise 1 \n" +
                                  "#2 for Exercise 2 \n" +
                                  "#0 for Exit \n "
                );

                var exercise = int.Parse(Console.ReadLine());
                if (exercise == 1) {
                    IncomeManager income = new IncomeManager();
                    income.CheckIncome();
                }

                else if (exercise == 2) {
                    AgeManager ageManager = new AgeManager();
                    ageManager.CheckAge();
                }
                else if (exercise == 0) {
                    _answer = true;
                }
            } while (_answer == false);
        }
    }
}