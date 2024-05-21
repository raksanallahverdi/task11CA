using System;
namespace Task1
{
	public class Calculator:ICalculator
	{
	

		public int Add(int number1,int number2)
		{
			return number1 + number2;
		}
        public int Substract(int number1, int number2)
        {
            return number1 - number2;
        }
        public int Divide(int number1, int number2)
        {
            return number1 / number2;
        }
        public int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
    }
}

