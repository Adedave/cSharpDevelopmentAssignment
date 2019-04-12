using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
           int i1 = 1, i2 =1, i3 = 1, i4 = 1;
            Console.WriteLine("Numbers between 1 and 10 using While loop.");
            while (i1 <= 10)
           {
                
                /*if (i1 == 10)
                {
                    Console.WriteLine($"{i1}.");
                    break;
                }*/
                Console.Write($"{i1} ");
               i1++;
           }
            Console.WriteLine("\n");

            Console.WriteLine("Numbers between 1 and 10 using DoWhile loop.");
            do
           {
                
                /*if (i2 == 10)
                {
                    Console.WriteLine($"{i2}.");
                    break;
                }*/
                Console.Write($"{i2} ");
               i2++;
           }
           while (i2 <= 10);
            Console.WriteLine("\n");

            Console.WriteLine("Odd numbers between 1 and 20 using While loop.");
            while (i3 <= 20)
           {
                
                /*if (i3 == 19)
                {
                    Console.WriteLine($"{i3}.");
                    break;
                }*/
                    

              Console.Write($"{i3} ");
              i3 += 2;
           }
            Console.WriteLine("\n");

            Console.WriteLine("Odd numbers between 1 and 20 using DoWhile loop.");
            do
            {
                
                /*if (i4 == 19)
                {
                    Console.WriteLine($"{i4}.");
                    break;
                }*/
                Console.Write($"{i4} ");
               i4 += 2;
            }
            while (i4 <= 20);
        
            Console.ReadLine();
        }
    }
}
