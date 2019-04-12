using System;

namespace BinaryConversion
{
    class Program
    {
        static void Main(string[] args)
        {
        interval:
            Console.WriteLine("Input the base of the number you want to convert");
            bool success1 = int.TryParse(Console.ReadLine(), out int baseNumber1);
            Console.WriteLine("Input the base you want to convert to");
            bool success2 = int.TryParse(Console.ReadLine(), out int baseNumber2);
            Console.WriteLine("Input the number you want to convert: ");
            // bool success = int.TryParse(Console.ReadLine(), out int response);
            string response = Console.ReadLine();
            //Console.WriteLine($"{response} converted to binary is {ConversionToBinary(response)}");
            // string hi = ConversionToBinary(response);
            Console.WriteLine($"{response} converted to decimal is {ConversionToDecimal(response, baseNumber)}");

            goto interval;
        }

        static string ConversionToBase(int decNumber, int baseValue)
        {
            
            string number = " ";

            while (decNumber > 0)
            {
                number = decNumber % baseValue + number;
                decNumber /= baseValue;
            }
            return number;
        }

        static double ConversionToDecimal(string binNumber, int baseValue)
        {
            double decimalNumber = 0;
            int i = 0;
            double value = 0;
            char[] binNum = binNumber.ToCharArray();
            double length = binNum.Length - 1;
            while (length >= 0 && i < binNum.Length)
            {
                value = int.Parse((binNum[i].ToString()));
                decimalNumber = (Math.Pow(baseValue, length) * value) + decimalNumber;
                i++;
                length--;
            }
            return decimalNumber;
        }

        /*namespace BinaryNumbers
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("input the base of the number you want to convert");
                string n = Console.ReadLine();
                Console.WriteLine("input the number you want to convert");
                string i = Console.ReadLine();
                Console.WriteLine(ConvertToDecimal(i, n));
                Console.ReadLine();

            }
            static string ConvertToBinary(int i)
            {
                string binaryNumber = "";
            startHere:
                if (i > 0)
                {

                    int binaryDigit = i % 2;
                    i = i / 2;
                    binaryNumber = binaryDigit.ToString() + binaryNumber;
                }
                else
                {
                    return binaryNumber;
                }
                goto startHere;



            }

            static double ConvertToDecimal(string i, string n)
            {
                // i is the number to be converted to decimal
                // n is the current base of the number to be converted
                int n2 = Convert.ToInt32(n); //n2 is converting n from string type to int
                double decimalNumber = 0;
                int x = 0;
                Char[] Num = i.ToCharArray();
                double length = Num.Length - 1;
                double i2 = 0;
                while (length >= 0 && x < Num.Length)
                {
                    i2 = int.Parse((Num[x].ToString())); // i2 is converting the char in the array position x from string to int
                    decimalNumber = ((Math.Pow(n2, length)) * i2) + decimalNumber;
                    x++;
                    length--;
                }
                return decimalNumber;

            }
            */


    }
}
