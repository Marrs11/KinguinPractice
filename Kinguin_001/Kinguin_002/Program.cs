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

            string[,] twoDArray = new string[4, 2];
           

            //TAKE INPUT

            Console.WriteLine("Enter your text: ");
            var s = Console.ReadLine();
            Console.WriteLine("\n");
            int counter = 0;

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

            string firstHalf;
            string secondHalf;

            for (int i = 0; i < strTwo.Length; i++)
            {
                firstHalf = strTwo[i].Substring(0, 4);
                twoDArray[i,0] = firstHalf;

                secondHalf = strTwo[i].Substring(4);
                twoDArray[i, 1] = secondHalf;
                Console.WriteLine("First half: " + firstHalf + "; Second half: " + secondHalf + "\n");

            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("This element [" + i + "] " + " [" + j + "]: " + twoDArray[i, j]);
                    
                }
            }

            

        }
    }
}
