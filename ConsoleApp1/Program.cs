using System;

namespace ConsoleApp1
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            int i;
            bool check = false;
            interval:
            Console.WriteLine("Input the required number: ");
            bool success = int.TryParse(Console.ReadLine(), out i);
            ParityCheck(i,check);
            if (check==false)
                 Console.WriteLine("Hurray! The number {0} is an odd number.", i);
            else
                Console.WriteLine("Hurray! The number {0} is an even number.", i);
            Loop1();
            Console.WriteLine("\n");
            Loop2();
            Console.WriteLine("\n");
            Loop3();
            Console.WriteLine("\n");
            Loop4();

            Console.ReadLine();
            goto interval;
        }

        public static bool ParityCheck(int number, bool parity)
        {
            if (number % 2 == 0)
                parity = true;
            return parity;
        }

        public static void Loop1()
        {
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine($"{i}");
                i++;
            }
                                   
        }

        public static void Loop2()
        {
            int i = 1;
            
            do
            {
                Console.WriteLine($"{i}");
                i++;
            }
            while (i <= 10);
                      
        }

        public static void Loop3()
        {
            int i = 1;
            
            while (i <= 20)
            {
                Console.WriteLine($"{i}");
                i += 2;
            }            
        }

        public static void Loop4()
        {
            int i = 1;
            do
            {
                Console.WriteLine($"{i}");
                i += 2;
            }
            while (i <= 20);
        }
    }
}