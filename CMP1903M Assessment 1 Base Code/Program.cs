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
            //Create input object
            //Create analyse object
            //Create report object

            Input input = new();
            Analyse analyse = new();
            Report report = new();

            //Define response string
            string response;

            //Ask the user if they want to enter their own text, or use text in a file
            Console.WriteLine("1. Do you want to enter the text via the keyboard?");
            Console.WriteLine("2.Do you want to read in the text from a file?");

            //Set response string to what the user inputs
            response = Console.ReadLine();

            //Define text string, this will be filled with either the users input or the text from a file
            string text;


            List<int> parameters;

            if (response == "1")
            {
                text = input.ManualTextInput();
                parameters = analyse.AnalyseText(text);
                report.outputConsole(parameters);
            }
            else if (response == "2")
            {
                Console.WriteLine("Please input the name of the file: ");
                string file = Console.ReadLine();
                text = input.FileTextInput(file);
                Console.WriteLine(text);

                parameters = analyse.AnalyseText(text);
                report.outputConsole(parameters);
            }
            else
            {
                Console.WriteLine("Invalid response.");
            }

            //Create an 'Analyse' object
            //Pass the text input to the 'analyseText' method

            //List<int> parameters = analyse.AnalyseText(text);

            //Receive a list of integers back


            //Report the results of the analysis

            //report.outputConsole(parameters);

            //TO ADD: Get the frequency of individual letters?

           
        }
        
        
    
    }
}
