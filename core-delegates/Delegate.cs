using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core_delegates
{
    delegate int NumberChanger(int number);

    public class Delegate
    {
        static int sum = 1;

        public static int Addition(int value)
        {
            sum += value;
            return sum;
        }
        public static int Multiply(int value)
        {
            sum *= value;
            return sum;
        }
        public static int GetSum()
        {
            return sum;
        }

        public static string AdditionOfTwoNumber(int value1, int value2)
        {
            return (value1 + value2).ToString();
        }

        public static bool IsGreaterThanTen(int value)
        {
            return value > 10;
        }
        public static void PrintAction(string value1, string value2)
        {
            Console.WriteLine($"{value1} {value2}");
        }
        public static void Seperator()
        {
            Console.WriteLine("\n-----------------------------------");
        }
    }
}
