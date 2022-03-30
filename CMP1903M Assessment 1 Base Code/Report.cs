using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {
        //Formats the values provided by the input and outputs the data to the console
        public void OutputConsole(List<int>input)
        {
            Console.WriteLine("");
            Console.WriteLine("Number of sentences: " + input[0]);
            Console.WriteLine("Number of vowels: " + input[1]);
            Console.WriteLine("Number of consonants: " + input[2]);
            Console.WriteLine("Number of upper case letters: " + input[3]);
            Console.WriteLine("Number of lower case letters: " + input[4]);
        }
    }
}
