using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal class Calc
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Это калькулятор. Введите выражение в виде \"a * b\":");
            var operation = Console.ReadLine().Split(' ').ToArray();

            Сalculation(GetNumber(operation[0]), Convert.ToChar(operation[1]), GetNumber(operation[2]), out double result);

            Console.WriteLine($"Результат: {result}");
            Console.ReadKey();
        }
        static double Сalculation(int a, char op, int b, out double res)
        {
            res = 0;
            try
            {
                switch (op)
                {
                    case '+': res= a + b; break;
                    case '*': res= a * b; break;
                    case '/': res= a / b; break;
                    case '-': res= a - b; break;
                }
            }
            catch (Exception ex) { Console.WriteLine($"Исключение: {ex.Message}"); }
            return res;
        }

        static int GetNumber(string s)
        {
            if (int.TryParse(s, out var x))
            {
                return x;
            }
            else
            {
                Console.WriteLine($"Исключение: Входное значение не может быть преобразовано в int");
                return 0;
            }
        }
    }
}
