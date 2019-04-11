using System;

namespace BinaryConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            interval:
            Console.WriteLine("Input the decimal number you want to convert: ");
            bool success = int.TryParse(Console.ReadLine(), out int response);
            
            Console.WriteLine($"{response} converted to binary is {Conversion(response)}");
           
            goto interval;
        }

        static string Conversion(int decNumber)
        {
           string number = " ";

            while (decNumber > 0)
            {                
               number = decNumber % 2 + number;
               decNumber /= 2;
            }
            return number;
        }
    }
}
