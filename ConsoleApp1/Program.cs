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
            Console.ReadLine();
            goto interval;
        }

        public static bool ParityCheck(int number, bool parity)
        {
            if (number % 2 == 0)
                parity = true;
            return parity;
        }
    }
}