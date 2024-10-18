using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_pr3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ввести положительные числа A, B, C. На прямоугольнике размера A x B размещено
              максимально возможное количество квадратов со стороной C (без наложений).
              Найти количество квадратов, размещенных на прямоугольнике. Операции умножения и деления не использовать.
             */
            Console.WriteLine("Введите положительное число для А: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите положительное число для B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите положительное число для C: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int i = 0; int j = 0;
            int n=c; int k = 0;
           
            
           if (c <= a && c <= b)
               
                {


                for (i = 0; i < a;)
                {

                    for (j = 0; j < b;)
                    {
                        j = j + c;
                        k = k + 1;
                    }
                    
                    i = i + c;

                }
                
                Console.WriteLine("Количество квадратов {0}", k);
                  
            }
            
            Console.ReadKey();




        }
    }
}
