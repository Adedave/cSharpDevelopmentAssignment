using System;

namespace BaseConversionTwo
{
    class Program
    {
        //static string response = "";
        //static int baseNumber1 = 0;
        static string allNumbers = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        static void Main(string[] args)
        {
        //MappingFunction();
        interval:
            Console.WriteLine("Welcome to my Base Conversion Calculator 1.0");
            Console.WriteLine("You can convert a number from any base to any base between base 2 and base 36\n\n");


            Console.WriteLine("\nInput the base of the number you want to convert:");
            bool success1 = int.TryParse(Console.ReadLine(), out int baseNumber1);
            Console.WriteLine("\nInput the base you want to convert the number to:");
            bool success2 = int.TryParse(Console.ReadLine(), out int baseNumber2);
            Console.WriteLine("\nInput the number you want to convert: ");
            check:
            string responseCheck = Console.ReadLine();
            if (ValidityCheck(responseCheck, baseNumber1) == false)
            {
                goto check;
            }
            string response = responseCheck;

            Console.WriteLine($"\n{response} converted to decimal is {MappingFunctionToDecimal(response, baseNumber1)}");
            long decimalNumber = MappingFunctionToDecimal(response, baseNumber1);
            Console.WriteLine($"\n{response} to base {baseNumber2} is {MappingFunctionToBase(decimalNumber, baseNumber2)}\n");

            goto interval;
        }

        static bool ValidityCheck(string number, int baseValue)
        {
            //long decNumber = 0;
            int value = 0;
            bool right = true;
            int determinant = 0;
            //int length = number.Length - 1;
            //test = "2abcd";
            string val = number.ToUpper();

            for (int i = 0; i < val.Length; i++)
            {
                // value equals the index position of each character in the string val
                value = allNumbers.IndexOf(val.Substring(i, 1));
                if (value >= baseValue)
                {
                    Console.WriteLine("Please enter a valid number: ");
                    //response = Console.ReadLine();
                    determinant++;
                    break;
                }
                ////decNumber = decNumber + ........;
                //decNumber += (long)(Math.Pow(baseValue, length) * value);
                //length--;
            }

            if (determinant == 1)
            {
                right =  false;
            }
            //char[] responseChar = response.ToUpper().ToCharArray();
            //foreach (char ch in responseChar)
            //{
            //    if ((ch == 'A' || ch == 'B' || ch == 'C' || ch == 'D' || ch == 'E' || ch == 'F') && baseNumber1 < 11)
            //    {
            //        Console.WriteLine("Please provide a valid number!");
            //        ValidityCheck();
            //        break;
            //    }
            //    else if ((ch == 'B' || ch == 'C' || ch == 'D' || ch == 'E' || ch == 'F') && baseNumber1 < 12)
            //    {
            //        Console.WriteLine("Please provide a valid number!");
            //        ValidityCheck();
            //        break;
            //    }
            //    else if ((ch == 'C' || ch == 'D' || ch == 'E' || ch == 'F') && baseNumber1 < 13)
            //    {
            //        Console.WriteLine("Please provide a valid number!");
            //        ValidityCheck();
            //        break;
            //    }
            //    else if ((ch == 'D' || ch == 'E' || ch == 'F') && baseNumber1 < 14)
            //    {
            //        Console.WriteLine("Please provide a valid number!");
            //        ValidityCheck();
            //        break;
            //    }
            //    else if ((ch == 'E' || ch == 'F') && baseNumber1 < 15)
            //    {
            //        Console.WriteLine("Please provide a valid number!");
            //        ValidityCheck();
            //        break;
            //    }
            //    else if ((ch == 'F') && baseNumber1 < 16)
            //    {
            //        Console.WriteLine("Please provide a valid number!");
            //        ValidityCheck();
            //        break;
            //    }
            //}
            return right;
        }
        
        // this method converts a number of a particular base between 2 and 36 to decimal
        static long MappingFunctionToDecimal(string number, int baseValue)
        {
            // I used the long data type because the result of this conversion might exceed the length of an int data type
            //For example if I parse abcdef123456789 through this function with decNumber as an int data type, the app would crash.
            long decNumber = 0; 
            int value = 0;
            int length = number.Length - 1;
            //test = "2abcd";
            string val = number.ToUpper();
            
            for (int i = 0; i < val.Length; i++)
            {
                // value equals the index position of each character in the string val
                value = allNumbers.IndexOf(val.Substring(i, 1));
                
                //decNumber = decNumber + ........;
                decNumber += (long)(Math.Pow(baseValue, length) * value);
                length--;
            }
            return decNumber;
        }

        // this method converts a decimal number to any base between 2 and 36
        static string MappingFunctionToBase(long decNumber, int baseValue)
        {
            //declared the finalBaseNumberValue because I would use it later in the function. 
            //Also, i had to intialize it because i cant use an unassigned variable
            string finalBaseNumberValue = "";
            
            //Once decNumber becomes zero(0) the function breaks out of the loop. 
            //This work because 1 % baseValue is the last operation for our conversion
            while (decNumber > 0)
            {
                //  I casted the modulus operation because, innately, its result will be a long data type which the allNumbers[i] operation would not recognize
                //  And I used a char data type for modulus because allNumbers[i] operation returns a character since allNumbers is an array of characters
                char modulus = allNumbers[(int)(decNumber %  baseValue)];

                //The below is different from finalBaseNumberValue += ......; 
                //For the above it means finalBaseNumberValue = finalBaseNumberValue + ......; 
                //which will make the first result of the modulus to be the first character 
                //in our string. This is the reverse of what we want. 
                //modulus.ToString() helps convert char modulus to string as char and string cannot be concatenated
                finalBaseNumberValue = modulus.ToString() + finalBaseNumberValue;
                
                //decNumber = decNumber / baseValue;
                decNumber /= baseValue;
            }       
            return finalBaseNumberValue;
        }
    }
}
