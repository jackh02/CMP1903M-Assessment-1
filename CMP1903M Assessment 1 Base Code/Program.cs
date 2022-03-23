//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        static void Main()
        {
            //Create 'Input' object
            //Get either manually entered text, or text from a file

            Input input = new();

            string response;

            Console.WriteLine("1. Do you want to enter the text via the keyboard?");
            Console.WriteLine("2.Do you want to read in the text from a file?");
            response = Console.ReadLine();

            string text = "";

            if (response == "1")
            {
                text = input.ManualTextInput();
            }
            else if (response == "2")
            {
                Console.WriteLine("Please input the name of the file: ");
                string file = Console.ReadLine();
                text = input.FileTextInput(file);
                Console.WriteLine(text);
            }
            else
            {
                Console.WriteLine("Invalid response.");
            }

            //Create an 'Analyse' object
            //Pass the text input to the 'analyseText' method

            Analyse analyse = new();

            List<int> parameters = analyse.AnalyseText(text);

            //Receive a list of integers back


            //Report the results of the analysis

            Report report = new();

            report.outputConsole(parameters);

            //TO ADD: Get the frequency of individual letters?

           
        }
        
        
    
    }
}
