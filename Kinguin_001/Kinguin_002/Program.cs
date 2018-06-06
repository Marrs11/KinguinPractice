using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Kinguin_002
{
    class Program
    {
        static void Main(string[] args)
        {
            //TAKE INPUT

            Console.WriteLine("Enter your text: ");
            var s = Console.ReadLine();
            Console.WriteLine("\n");
            int counter = 0;
            //string.IsNullOrEmpty(s)
            if (s.Length > 4 || s.Length < 4)
            {
                Console.WriteLine("Text must contain only 4 letters!");
                s = Console.ReadLine();
            }

            //bool allLetters = Regex.IsMatch(s, @"^[a-zA-Z]$");
            //if (allLetters == false)
            //{
            //    Console.WriteLine("Text must only contain letters!");
            //    s = Console.ReadLine();
            //}

            //if(char.IsDigit(Convert.ToChar(s)))
            //{
            //    Console.Write("Digits Are NotAllowed....\n");
            //    Console.Write("Please Enter Correct Name: ");
            //    s = Console.ReadLine(); 
            //}

            string[] strTwo = new String[s.Length];
            
            var chars = s.ToCharArray();
            Console.WriteLine("Original string: {0}", s);

            //SPLIT INPUT INTO CHAR ARRAY

            Console.WriteLine("\n" + "Character array:");
            for (int ctr = 0; ctr < chars.Length; ctr++)
            {
                Console.WriteLine("   {0}: {1}", ctr, chars[ctr]);
            }

            Console.WriteLine("\n");

            //CONVERT CHAR ARRAY INTO BINARY NUMBER

            foreach (char c in chars)
            {
                Console.WriteLine("Binary value of " + c + " is " + Convert.ToString(c, 2).PadLeft(8, '0') + "\n");
                String splt = Convert.ToString(c, 2).PadLeft(8, '0');
                if (counter < 4)
                {
                    strTwo[counter] = splt;
                }

                counter++;
            }

            for (int i = 0; i < strTwo.Length; i++)
            {
                Console.WriteLine("Binary array: " + strTwo[i]);
            }

            Console.WriteLine("\n");

            //CONVERT BINARY NUMBER BACK TO STRING

            string binaryToString = "";
            int len = chars.Length;
            for (int i = 0; i < len; i++)
            {
                if (i != 0)
                {
                    binaryToString += ",";
                }
                binaryToString += chars[i].ToString();
            }

            Console.WriteLine("Test convertion from binary values = " + binaryToString + "\n");
            
            //SPLIT BINARY NUMBERS IN HALF

            Console.WriteLine("Split binary arrays:" + "\n");

            for (int i = 0; i < strTwo.Length; i++)
            {
                string value = strTwo[i].Substring(0, 4);

                string value2 = strTwo[i].Substring(4);
                Console.WriteLine("First half: " + value + "; Second half: " + value2);
            }
        }
    }
}
