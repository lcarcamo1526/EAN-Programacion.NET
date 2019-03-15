using System;

namespace Taller6 {
    class Program {
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
                    Exercises1 ex1 = new Exercises1();
                    ex1.Ex1();
                }

                else if (exercise == 2) {
                    Excercise2 ex2 = new Excercise2();
                    ex2.Ex2();
                }


                else if (exercise == 0) {
                    _answer = true;
                }
            } while (_answer == false);
        }
    }
}