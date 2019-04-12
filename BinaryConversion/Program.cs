using System;

namespace BinaryConversion
{
    class Program
    {
        static void Main(string[] args)
        {
        interval:
            Console.WriteLine("Input the binary number you want to convert: ");
           // bool success = int.TryParse(Console.ReadLine(), out int response);
            string response = Console.ReadLine();
            //Console.WriteLine($"{response} converted to binary is {ConversionToBinary(response)}");
           // string hi = ConversionToBinary(response);
            Console.WriteLine($"{response} converted to decimal is {ConversionToDecimal(response)}");

            goto interval;
        }

        static string ConversionToBinary(int decNumber)
        {
           string number = " ";

            while (decNumber > 0)
            {                
               number = decNumber % 2 + number;
               decNumber /= 2;
            }
            return number;
        }

        static double ConversionToDecimal(string binNumber)
        {
            double decimalNumber = 0;
            int i = 0;
            double value = 0;
            char[] binNum = binNumber.ToCharArray();
            double length = binNum.Length - 1;
            while (length >= 0 && i < binNum.Length )
            {
                value = int.Parse((binNum[i].ToString()));
                decimalNumber = (Math.Pow(2,length) * value) + decimalNumber;
                i++;
                length--;
            }
            return decimalNumber;
        }
    }
}
