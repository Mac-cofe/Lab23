using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab23
{
    class Program
    {
        static int fact=1;
        public static int x=0;

        static void Main(string[] args)
        {
            int fact = FactorialAsync().Result;

            Console.WriteLine($"{x}! = {fact}");
            Console.WriteLine("Метод Main окончил работу");
            Console.ReadKey();
        }

        static int Fact()
        {
            Console.WriteLine("Факториал какого числа вычислить?");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (x != 0)
            {
                for (int i = 1; i < x + 1; i++)
                {
                    Console.WriteLine(i);
                    fact *= i;
                    Thread.Sleep(300);
                }
            }
            else fact = 0;
            return fact;
        }

        static async Task<int> FactorialAsync()
        {
            Console.WriteLine("Метод FactorialAsync начал работу");
            int rezult = await Task.Run(() => Fact());
            Console.WriteLine("Метод FactorialAsync окончил работу");
            return rezult;
        }

    }
}
