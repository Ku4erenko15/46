using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        enum Operation
        {
            Add=1 ,
            Subtract,
            Multiply,
            Divide
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1 - Сложение (+)");
            Console.WriteLine("2 - Вычитание (-)");
            Console.WriteLine("3 - Умножение (*)");
            Console.WriteLine("4 - Деление (/)");

            int operationInput = Convert.ToInt32(Console.ReadLine());

            if (!Enum.IsDefined(typeof(Operation), operationInput))
            {
                Console.WriteLine("Ошибка: неверный выбор операции.");
                return;
            }

            Operation op = (Operation)operationInput;
            double result = 0;
            bool success = true;

            switch (op)
            {
                case Operation.Add:
                    result = a + b;
                    break;
                case Operation.Subtract:
                    result = a - b;
                    break;
                case Operation.Multiply:
                    result = a * b;
                    break;
                case Operation.Divide:
                    if (b != 0)
                    {
                        result = a / b;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: деление на ноль.");
                        success = false;
                    }
                    break;
            }

            if (success)
            {
                Console.WriteLine($"Результат: {result}");
            }
            Console.ReadKey();
        }
    }
}
