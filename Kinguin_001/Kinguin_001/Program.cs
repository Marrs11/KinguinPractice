using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinguin_001
{
    class Program
    {
        static void Main(string[] args)
        {

            //String[] array = {"00", "11", "01", "10"};




            //var A = "00";
            //var T = "11";
            //var G = "01";
            //var C = "10";

            //Console.WriteLine(A + ", " + T + ", " + G + ", " + C);

            Hashtable hashtable = new Hashtable();
            hashtable["00"] = 'A';
            hashtable["11"] = 'T';
            hashtable["01"] = 'G';
            hashtable["10"] = 'C';

            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine("{0}, {1}", entry.Key, entry.Value);
            }
        }
    }
}
