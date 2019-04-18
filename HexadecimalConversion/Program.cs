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
            //string test = "123fe";
            //Console.WriteLine(test.ToUpper());
            Console.WriteLine("Input the hexadecimal number you want to convert to decimal: ");
            string response = Console.ReadLine();
            Conversion(response);
            Console.WriteLine($"{response} converted to decimal is {Conversion(response)}");
            int decimalNumber = Conversion(response);
            Console.WriteLine($"{Conversion(response)} back to hexadecimal is {ConversionToBase(decimalNumber, 16)}");

            goto interval;
        }
        // for now inputing a letter beyond 'F' crashes the application
        static int Conversion(string hexNumber)
        {
            char[] hexNumberChar = hexNumber.ToUpper().ToCharArray();
            int i = 0;
            double decNumber = 0;
            double value = 0;
            double length = hexNumber.Length - 1;
            while (i<hexNumber.Length)
            {
                if (hexNumberChar[i].Equals('A'))
                {
                    decNumber = (Math.Pow(16, length) * 10) + decNumber;
                }
                else if (hexNumberChar[i].Equals('B'))
                {
                    decNumber = (Math.Pow(16, length) * 11) + decNumber;
                }
                else if (hexNumberChar[i].Equals('C'))
                {
                    decNumber = (Math.Pow(16, length) * 12) + decNumber;
                }
                else if (hexNumberChar[i].Equals('D'))
                {
                    decNumber = (Math.Pow(16, length) * 13) + decNumber;
                }
                else if (hexNumberChar[i].Equals('E'))
                {
                    decNumber = (Math.Pow(16, length) * 14) + decNumber;
                }
                else if (hexNumberChar[i].Equals('F'))
                {
                    decNumber = (Math.Pow(16, length) * 15) + decNumber;
                }
                else
                {
                    value = double.Parse(hexNumberChar[i].ToString());
                    decNumber = (Math.Pow(16, length) * value) + decNumber;
                }
                
                i++;
                length--;
            }
            int decNumberInt = Convert.ToInt32(decNumber);
            return decNumberInt;
        }

        static string ConversionToBase(int decNumber, int baseValue)
        {

            string number = " ";

            while (decNumber > 0)
            {
                if (decNumber % baseValue == 10)
                {
                    number = "A" + number;
                }
                else if (decNumber % baseValue == 11)
                {
                    number = "B" + number;
                }
                else if (decNumber % baseValue == 12)
                {
                    number = "C" + number;
                }
                else if (decNumber % baseValue == 13)
                {
                    number = "D" + number;
                }
                else if (decNumber % baseValue == 14)
                {
                    number = "E" + number;
                }
                else if (decNumber % baseValue == 15)
                {
                    number = "F" + number;
                }
                else
                {
                    number = decNumber % baseValue + number;
                }
                decNumber /= baseValue;
            }
            return number;
        }
    }
}
