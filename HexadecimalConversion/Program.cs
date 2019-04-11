using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexadecimalConversion
{
    class Program
    {
        static void Main(string[] args)
        {
        interval:
            Console.WriteLine("Input the hexadecimal number you want to convert to decimal: ");
            string response = Console.ReadLine();
            Conversion(response);
            Console.WriteLine($"{response} converted to decimal is {Conversion(response)}");

            goto interval;
        }

        static int Conversion(string hexNumber)
        {
            int i = 0, decNumber = 0;
            int length = hexNumber.Length;
            while (i > length)
            {
                decNumber = 16^length + decNumber;
                length--;
            }
            return decNumber;
        }
    }
}
