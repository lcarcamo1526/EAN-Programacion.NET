using System;
using static System.Convert;


namespace Taller5 {
    /// <summary>
    /// First Exercise of workshop
    /// </summary>
    class IncomeManager {
        private static int _hourSalary, _monthsHours, _pension, _professionalRisk, _risk;
        private static string _name;
        private static bool _answer;

        /// <summary>
        /// Check income taxes, net wage and brute wage
        /// </summary>
        public void CheckIncome() {
            Console.Clear();
            Console.WriteLine("----------------------------------------------------------------------");
            while (_answer == false) {
                Console.WriteLine("Welcome to income Manager, please enter the following data :");
                Console.WriteLine("Please enter your name");
                _name = Console.ReadLine();
                Console.WriteLine("Hello Mr " + _name + ", How many hours do you work at month ?");
                _monthsHours = ToInt32(Console.ReadLine());
                Console.WriteLine("Ok, you're a hard worker, how much you win per hour? ");
                _hourSalary = ToInt32(Console.ReadLine());
                Console.WriteLine("Ok, there is a lot, How much you contribute to your pension per month ?");
                _pension = ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Please choose one of the the following  risk plane \n" +
                                  "Number 1 Plan   2% Risk \n" +
                                  "Number 2 Plan   7% Risk \n" +
                                  "Number 3 Plan   10% Risk \n");
                _professionalRisk = ToInt32(Console.ReadLine());

                switch (_professionalRisk) {
                    case 1:
                        _risk = (int) (0.02 * _pension);
                        break;
                    case 2:
                        _risk = (int) (0.07 * _pension);
                        break;
                    case 3:
                        _risk = (int) (0.1 * _pension);
                        break;

                    default:
                        _risk = (int) (0.02 * _pension);
                        break;
                }

                Console.Clear();
                var salary = _hourSalary * _monthsHours;
                var taxes = _risk + 0.15f * salary;
                Console.WriteLine("Ok" + " Mr " + _name + " here is your brute wage:  \n" + salary);
                Console.WriteLine("Taxes : " + taxes);
                Console.WriteLine("And, this  is your net wage:  \n" + (salary - taxes));

                _answer = true;
            }
        }
    }
}