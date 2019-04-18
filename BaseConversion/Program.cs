using System;

namespace BinaryConversion
{
    class Program
    {
        static string response = "";
        static int baseNumber1 = 0;
        static void Main(string[] args)
        {
            //MappingFunction();
            interval:
            Console.WriteLine("Welcome to my Base Conversion Calculator 1.0");
            Console.WriteLine("You can convert a number from any base to any base between base 2 and base 36\n\n");
                
        
            Console.WriteLine("\nInput the base of the number you want to convert:");
            bool success1 = int.TryParse(Console.ReadLine(), out  baseNumber1);
            Console.WriteLine("\nInput the base you want to convert the number to:");
            bool success2 = int.TryParse(Console.ReadLine(), out int baseNumber2);
            Console.WriteLine("\nInput the number you want to convert: ");
            ValidityCheck();
            //bool success = int.TryParse(Console.ReadLine(), out int response);
           
            //ConversionToDecimal(11101, 2);
            //Console.WriteLine($"11101 converted to binary is {ConversionToDecimal("1011",2)}");
            //Console.WriteLine($"29 converted to base 2 is {ConversionToBase(11, 2)}");
            //Console.ReadLine();
            //ConversionToDecimal(response, baseNumber1);
            Console.WriteLine($"\n{response} converted to decimal is {ConversionToDecimal(response, baseNumber1)}");
            long decimalNumber = ConversionToDecimal(response, baseNumber1);
            Console.WriteLine($"\n{response} to base {baseNumber2} is {ConversionToBase(decimalNumber, baseNumber2)}\n");

            goto interval;
        }

        static void ValidityCheck()
        {
            response = Console.ReadLine();
            //response.
            char[] responseChar = response.ToUpper().ToCharArray();
            foreach (char ch in responseChar)
            {
                if ((ch == 'A' || ch == 'B' || ch == 'C' || ch == 'D' || ch == 'E' || ch == 'F') && baseNumber1 < 11)
                {
                    Console.WriteLine("Please provide a valid number!");
                    ValidityCheck();
                    break;
                }
                else if ((ch == 'B' || ch == 'C' || ch == 'D' || ch == 'E' || ch == 'F') && baseNumber1 < 12)
                {
                    Console.WriteLine("Please provide a valid number!");
                    ValidityCheck();
                    break;
                }
                else if ((ch == 'C' || ch == 'D' || ch == 'E' || ch == 'F') && baseNumber1 < 13)
                {
                    Console.WriteLine("Please provide a valid number!");
                    ValidityCheck();
                    break;
                }
                else if ((ch == 'D' || ch == 'E' || ch == 'F') && baseNumber1 < 14)
                {
                    Console.WriteLine("Please provide a valid number!");
                    ValidityCheck();
                    break;
                }
                else if ((ch == 'E' || ch == 'F') && baseNumber1 < 15)
                {
                    Console.WriteLine("Please provide a valid number!");
                    ValidityCheck();
                    break;
                }
                else if ((ch == 'F') && baseNumber1 < 16)
                {
                    Console.WriteLine("Please provide a valid number!");
                    ValidityCheck();
                    break;
                }
            }
            
            return;
        }

        // this method converts a decimal number to any base between 2 and 36

        static string ConversionToBase(long decNumber, int baseValue)
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
                else if (decNumber % baseValue == 16)
                {
                    number = "G" + number;
                }
                else if (decNumber % baseValue == 17)
                {
                    number = "H" + number;
                }
                else if (decNumber % baseValue == 18)
                {
                    number = "I" + number;
                }
                else if (decNumber % baseValue == 19)
                {
                    number = "J" + number;
                }
                else if (decNumber % baseValue == 20)
                {
                    number = "K" + number;
                }
                else if (decNumber % baseValue == 21)
                {
                    number = "L" + number;
                }
                else if (decNumber % baseValue == 22)
                {
                    number = "M" + number;
                }
                else if (decNumber % baseValue == 23)
                {
                    number = "N" + number;
                }
                else if (decNumber % baseValue == 24)
                {
                    number = "O" + number;
                }
                else if (decNumber % baseValue == 25)
                {
                    number = "P" + number;
                }
                else if (decNumber % baseValue == 26)
                {
                    number = "Q" + number;
                }
                else if (decNumber % baseValue == 27)
                {
                    number = "R" + number;
                }
                else if (decNumber % baseValue == 28)
                {
                    number = "S" + number;
                }
                else if (decNumber % baseValue == 29)
                {
                    number = "T" + number;
                }
                else if (decNumber % baseValue == 30)
                {
                    number = "U" + number;
                }
                else if (decNumber % baseValue == 31)
                {
                    number = "V" + number;
                }
                else if (decNumber % baseValue == 32)
                {
                    number = "W" + number;
                }
                else if (decNumber % baseValue == 33)
                {
                    number = "X" + number;
                }
                else if (decNumber % baseValue == 34)
                {
                    number = "Y" + number;
                }
                else if (decNumber % baseValue == 35)
                {
                    number = "Z" + number;
                }
                else
                {
                    number = decNumber % baseValue + number;
                }
                decNumber /= baseValue;
            }
            return number;
        }

        // this method converts a number of a particular base between 2 and 36 to decimal
        static long ConversionToDecimal(string baseNumber, int baseValue)
        {
            char[] baseNumberChar = baseNumber.ToUpper().ToCharArray();
            int i = 0;
            double decNumber = 0;
            double value = 0;
            double length = baseNumber.Length - 1;
            while (i < baseNumber.Length)
            {
                if (baseNumberChar[i].Equals('A') && 10 < baseValue)
                {
                    decNumber = (Math.Pow(baseValue, length) * 10) + decNumber;
                }
                else if (baseNumberChar[i].Equals('B') && 11 < baseValue)
                {
                    decNumber = (Math.Pow(baseValue, length) * 11) + decNumber;
                }
                else if (baseNumberChar[i].Equals('C') && 12 < baseValue)
                {
                    decNumber = (Math.Pow(baseValue, length) * 12) + decNumber;
                }
                else if (baseNumberChar[i].Equals('D') && 13 < baseValue)
                {
                    decNumber = (Math.Pow(baseValue, length) * 13) + decNumber;
                }
                else if (baseNumberChar[i].Equals('E') && 14 < baseValue)
                {
                    decNumber = (Math.Pow(baseValue, length) * 14) + decNumber;
                }
                else if (baseNumberChar[i].Equals('F') && 15 < baseValue)
                {
                    decNumber = (Math.Pow(baseValue, length) * 15) + decNumber;
                }
                else if (baseNumberChar[i].Equals('G') && 16 < baseValue)
                {
                    decNumber = (Math.Pow(baseValue, length) * 16) + decNumber;
                }
                else if (baseNumberChar[i].Equals('H') && 17 < baseValue)
                {
                    decNumber = (Math.Pow(baseValue, length) * 17) + decNumber;
                }
                else if (baseNumberChar[i].Equals('I') && 18 < baseValue)
                {
                    decNumber = (Math.Pow(baseValue, length) * 18) + decNumber;
                }
                else if (baseNumberChar[i].Equals('J') && 19 < baseValue)
                {
                    decNumber = (Math.Pow(baseValue, length) * 19) + decNumber;
                }
                else if (baseNumberChar[i].Equals('K') && 20 < baseValue)
                {
                    decNumber = (Math.Pow(baseValue, length) * 20) + decNumber;
                }
                else if (baseNumberChar[i].Equals('L') && 21 < baseValue)
                {
                    decNumber = (Math.Pow(baseValue, length) * 21) + decNumber;
                }
                else if (baseNumberChar[i].Equals('M') && 22 < baseValue)
                {
                    decNumber = (Math.Pow(baseValue, length) * 22) + decNumber;
                }
                else if (baseNumberChar[i].Equals('N') && 23 < baseValue)
                {
                    decNumber = (Math.Pow(baseValue, length) * 23) + decNumber;
                }
                else if (baseNumberChar[i].Equals('O') && 24 < baseValue)
                {
                    decNumber = (Math.Pow(baseValue, length) * 24) + decNumber;
                }
                else if (baseNumberChar[i].Equals('P') && 25 < baseValue)
                {
                    decNumber = (Math.Pow(baseValue, length) * 25) + decNumber;
                }
                else if (baseNumberChar[i].Equals('Q') && 26 < baseValue)
                {
                    decNumber = (Math.Pow(baseValue, length) * 26) + decNumber;
                }
                else if (baseNumberChar[i].Equals('R') && 27 < baseValue)
                {
                    decNumber = (Math.Pow(baseValue, length) * 27) + decNumber;
                }
                else if (baseNumberChar[i].Equals('S') && 28 < baseValue)
                {
                    decNumber = (Math.Pow(baseValue, length) * 28) + decNumber;
                }
                else if (baseNumberChar[i].Equals('T') && 29 < baseValue)
                {
                    decNumber = (Math.Pow(baseValue, length) * 29) + decNumber;
                }
                else if (baseNumberChar[i].Equals('U') && 30 < baseValue)
                {
                    decNumber = (Math.Pow(baseValue, length) * 30) + decNumber;
                }
                else if (baseNumberChar[i].Equals('V') && 31 < baseValue)
                {
                    decNumber = (Math.Pow(baseValue, length) * 31) + decNumber;
                }
                else if (baseNumberChar[i].Equals('W') && 32 < baseValue)
                {
                    decNumber = (Math.Pow(baseValue, length) * 32) + decNumber;
                }
                else if (baseNumberChar[i].Equals('X') && 33 < baseValue)
                {
                    decNumber = (Math.Pow(baseValue, length) * 33) + decNumber;
                }
                else if (baseNumberChar[i].Equals('Y') && 34 < baseValue)
                {
                    decNumber = (Math.Pow(baseValue, length) * 34) + decNumber;
                }
                else if (baseNumberChar[i].Equals('Z') && 35 < baseValue)
                {
                    decNumber = (Math.Pow(baseValue, length) * 35) + decNumber;
                }
                else
                {
                    value = double.Parse(baseNumberChar[i].ToString());
                    decNumber = (Math.Pow(baseValue, length) * value) + decNumber;
                }

                i++;
                length--;
            }
            long decNumberInt = Convert.ToInt64(decNumber);
            return decNumberInt;
        }

        static void MappingFunction()
        {
            string val = "1ab7".ToUpper(), temp = "";
            //int n = 16, n1 = 10;
            string allNumbers = "0123456789abcdefghijklmnopqrstuvwxyz".ToUpper();
            for (int i = 0; i < val.Length; i++)
            {
                temp += allNumbers.IndexOf(val.Substring(i,1)).ToString() + "_";
            }
            Console.WriteLine(temp);
            Console.ReadLine();
        }
    }
}
