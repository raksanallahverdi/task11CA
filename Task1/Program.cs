
using System;
namespace Task1
{


    public static class Program
    {
        public static void Main()
        {
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Add(6, 7) );
            Console.WriteLine(calculator.Divide(9, 3));

        }
    }

}

