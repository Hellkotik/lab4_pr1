using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_pr1
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
                Ввести целое число N > 0.Найти квадрат данного числа, используя для его вычисления следующую
                формулу: N2 = 1 + 3 + 5 + ... +(2 * N – 1).
                После добавления к сумме каждого слагаемого выводить текущее значение суммы(в результате будут выведены квадраты всех целых чисел от 1 до N).
            */

            Console.WriteLine("Введите число больше нуля");
            double m = 0;
            double n = Convert.ToDouble(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                // m = m + (2 * i - 1);
                m += (2 * i - 1);
                Console.WriteLine("Число {0}, квадрат числа равен {1} ", i, m);
            }

            Console.ReadKey();


        }
    }
}