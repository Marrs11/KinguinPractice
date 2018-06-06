using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DnaProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = GetInput();
            //while (InputValidation(s) == false)
            //{
            //    InputValidation(s);
            //}

            SplitInput(s);
            ConvertToBinary(s);


        }

        public static String GetInput()
        {
            Console.WriteLine("Enter your text: ");
            String input = Console.ReadLine();
            Console.WriteLine("\n");
            
            return input;
        }

        //public static bool InputValidation(String s)
        //{
        //    s = Console.ReadLine();

        //    if ((s.Length > 4 || s.Length < 4) == false)
        //    {
        //        Console.WriteLine("Text must contain only 4 letters!");
                
        //        return false;
        //    }

        //    bool allLetters = Regex.IsMatch(s, @"^[a-zA-Z]$");
        //    if (allLetters == false)
        //    {
        //        Console.WriteLine("Text must only contain letters!");
                
        //        return false;
        //    }

        //    if (char.IsDigit(Convert.ToChar(s)))
        //    {
        //        Console.Write("Digits Are NotAllowed....\n");
        //        Console.Write("Please Enter Correct Name: ");
               
        //        return false;

        //    }

        //    return true;

        //}

        public static string SplitInput(string s)
        {
            string[] strTwo = new String[s.Length];
            var chars = s.ToCharArray();
            Console.WriteLine("Original string: {0}", s);
            Console.WriteLine("\n" + "Character array:");
            for (int ctr = 0; ctr < chars.Length; ctr++)
            {
                Console.WriteLine("   {0}: {1}", ctr, chars[ctr]);
            }

            Console.WriteLine("\n");

            return s;
        }

        public static string ConvertToBinary(string s)
        {
            foreach (char c in SplitInput(s))
            {
                string[] strTwo = new String[s.Length];
                int counter = 0;
                Console.WriteLine("Binary value of " + c + " is " + Convert.ToString(c, 2).PadLeft(8, '0') + "\n");
                String splt = Convert.ToString(c, 2).PadLeft(8, '0');
                if (counter < 4)
                {
                    return strTwo[counter] = splt;
                }

                counter++;

            }

            return s;
        }

        
    }
}
