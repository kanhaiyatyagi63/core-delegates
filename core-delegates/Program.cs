using System;

namespace core_delegates
{
    // delegates
    // 1. Single cast 
    // 2. Multi cast
    // 3. Generic
    // 3.a Action => no return 
    // 3.b Predicate => only return boolean value
    // 3.c Func => return anything that you want from the function
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello Delegates!");

            NumberChanger globalDelegate = null;
            var additionNumberChanger = new NumberChanger(Delegate.Addition);
            var multiplyNumberChanger = new NumberChanger(Delegate.Multiply);

            Delegate.Seperator();

            #region single cast delegate
            additionNumberChanger(5);
            Console.WriteLine($"The sum is: {Delegate.GetSum()}");
            multiplyNumberChanger(5);
            Console.WriteLine($"The sum is: {Delegate.GetSum()}");
            #endregion

            Delegate.Seperator();

            #region multi cast delegate

            globalDelegate = multiplyNumberChanger;
            globalDelegate += additionNumberChanger;
            globalDelegate(5);

            Console.WriteLine($"The sum is: {Delegate.GetSum()}");

            #endregion

            Delegate.Seperator();

            #region Generic 1. Func Delegate
            // Syntax: Func<int, string, string> VariableName = reference
            // Func no paramter restriction, get any type of output that you want
            Func<int, int, string> Addition = Delegate.AdditionOfTwoNumber;
            var funcResult = Addition(10, 15);
            Console.WriteLine($"Func Delegate: Sum is: {funcResult}");
            #endregion
            Delegate.Seperator();

            #region Generic 2. Predicate Delegate
            // Syntax: Predicate<T> VariableName = reference
            // Func one paramter restriction, get only boolean type output
            int value = 9;
            Predicate<int> isGreaterThan = Delegate.IsGreaterThanTen;
            bool predresult = isGreaterThan(value);
            Console.WriteLine($"{value} is greater than 10: {predresult}");
            #endregion
            Delegate.Seperator();

            #region Generic 3. Action Delegate
            // Syntax: Action<int, string> VariableName = reference
            // Func no paramter restriction, no return
            Action<string, string> print = Delegate.PrintAction;
            print("Welcome!","I am a action delegate");
            #endregion
        }
    }
}
