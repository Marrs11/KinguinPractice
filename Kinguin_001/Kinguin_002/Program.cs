using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinguin_002
{
    class Program
    {
       

        static void Main(string[] args)
        {


            
            Console.WriteLine("Enter your text: ");
            var s = Console.ReadLine();
            String[] strTwo = new String[s.Length];

            var chars = s.ToCharArray();
            Console.WriteLine("Original string: {0}", s);
            Console.WriteLine("Character array:");
            for (int ctr = 0; ctr < chars.Length; ctr++)
            {
                Console.WriteLine("   {0}: {1}", ctr, chars[ctr]);
            }

            foreach (char c in chars)
            {
                Console.WriteLine("Binary value of " + c + " is " + Convert.ToString(c, 2).PadLeft(8, '0'));
                String splt = Convert.ToString(c, 2).PadLeft(8, '0');
                int i = 0;
                strTwo[i] = splt;
                Console.WriteLine(strTwo[i]);
                //for (int i = 0; i < s.Length; i++)
                //{


                //    Console.WriteLine(splt);
                //}

                


            }
            Console.WriteLine(strTwo[0] + "" + strTwo[1] + "" + strTwo[2] + "" + strTwo[3]);



            //for (int i = 0; i < s.Length; i++)
            //{
            //    Console.WriteLine();
            //}

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

            
            Console.WriteLine("Convertion from binary values = " + binaryToString);


            //string input = chars.ToString();

            //string sub = input.Substring(4, 4);
            //Console.WriteLine("Substring: {0}", sub);
        }
        


    }
}
