using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work_1
{
    public class Calculator
    {
        public int Addition(int firstValue, int secondValue)
        {
            return firstValue + secondValue;
        }

        public int Subtraction(int firstValue, int secondValue)
        {
            return firstValue - secondValue;
        }

        public int Multiplication(int firstValue, int secondValue)
        {
            return firstValue * secondValue;
        }

        public double Division(int firstValue, int secondValue)
        {
            if (secondValue == 0)
            {
                Console.WriteLine("Помилка!!!");
            }
            return (double)firstValue / secondValue;
        }
    }

    class Program
    {
        static void Main()
        {
            Calculator calculator = new Calculator();

            Console.Write("Введіть переше число: ");
            int firstValue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть друге число: ");
            int secondValue = Convert.ToInt32(Console.ReadLine());

            Console.Write("Оберить операцію '+', '-', '*', '/' : ");
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    Console.WriteLine($"Додавання: {firstValue} + {secondValue} = {calculator.Addition(firstValue, secondValue)}");
                    break;
                case "-":
                    Console.WriteLine($"Віднімання: {firstValue} - {secondValue} = {calculator.Subtraction(firstValue, secondValue)}");
                    break;
                case "*":
                    Console.WriteLine($"Множення: {firstValue} * {secondValue} = {calculator.Multiplication(firstValue, secondValue)}");
                    break;
                case "/":
                    Console.WriteLine($"Ділення: {firstValue} / {secondValue} = {calculator.Division(firstValue, secondValue)}");
                    break;
                default:
                    Console.WriteLine("Не вірно введена операція");
                    break;
            }
        }
    }
}
