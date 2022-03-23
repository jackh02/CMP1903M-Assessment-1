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
            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();

            //Create 'Input' object
            //Get either manually entered text, or text from a file

            Input input = new Input();

            string response = null;

            Console.WriteLine("1. Manual or 2. File Input? (Please put 1 or 2) ");
            response = Console.ReadLine();

            string text = "";

            if (response == "1")
            {
                text = input.manualTextInput();
            }
            else if (response == "2")
            {
                Console.WriteLine("Please input the name of the file: ");
                string file = Console.ReadLine();
                text = input.fileTextInput(file);
                Console.WriteLine(text);
            }
            else
            {
                Console.WriteLine("Invalid response.");
            }

            //Create an 'Analyse' object
            //Pass the text input to the 'analyseText' method

            Analyse analyse = new Analyse();

            analyse.analyseText(text);

            //Receive a list of integers back


            //Report the results of the analysis

            Report report = new Report();

            report.outputConsole(parameters);

            //TO ADD: Get the frequency of individual letters?

           
        }
        
        
    
    }
}
