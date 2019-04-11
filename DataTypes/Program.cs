using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Substring
    {
        static int len;
        static void Main(string[] args)
        {
            Console.WriteLine("Input a word");
            string abc = Console.ReadLine();
            string c = abc.ToLower().ToUpper().ToLower().Substring(abc.Length - 2, 2);
            Console.WriteLine(c);
            //Console.ReadKey();
            len = abc.Length;

            string newReplacedString = c.Replace("pp", "$$");

            bool contains = abc.Contains("pp"); //true

            bool startsWith = abc.StartsWith("eople"); //false

            int index = abc.IndexOf("P");  //6


            //Left
            Console.WriteLine(LeftFunction(abc,3));
            //Mid
            Console.WriteLine(MidFunction(abc, 6, 2));
            //Right
            Console.WriteLine(RightFunction(abc, 3));

            //SplitFunction

            Console.ReadKey();
        }

        public static string LeftFunction(string word, int noOfCharacter)
        {
            string d = word.Substring(0, noOfCharacter);
            return d;
        }

        public static string MidFunction(string word, int startIndex, int endIndex)
        {
           /* int i;
            if (word.Length % 2 == 0)
            {
                i = (word.Length / 2) - 2;
            }
            else
            {
                i = (word.Length / 2) - 1;
            }*/
            string e = word.Substring(startIndex -1, endIndex);
            
            return e;
        }

        public static string RightFunction(string word, int noOfCharacter)
        {
            string f = word.Substring(len - noOfCharacter, noOfCharacter);
            //string f = word.Substring(len - noOfCharacter);
            return f;
        }

        public static void SplitFunctiion()
        {
            //string b;
            string postTags = "Politics, election, 2019 voters card, presidential Election";

            string[] separators = new[] { ",", "_" };
            string[] b = postTags.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine(b.Length + "Separate string found");
            if (b.Length > 0)
            {
                foreach (string item in b)
                {
                    Console.WriteLine(item);
                }
            }

            return;
        }

        public static string JoinFunction()
        {
            //String.Join()
            string joinedString = String.Join(", ", b);
            return joinedString;
        }

        // Character Datatype : char or System.Char in CTS (Common Type Specification)

        void CharDemo()
        {
            char a = 'A';
            char b = 'B';
            //bool c = char.
            //string ab = 
        }



    }
}
