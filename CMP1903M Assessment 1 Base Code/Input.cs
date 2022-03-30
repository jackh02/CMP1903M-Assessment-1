using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        //Handles the text input for Assessment 1
        private string? text = "";
        
        //Reads the text inputted by the user and returns it to the Program class
        public string ManualTextInput()
        {
            Console.WriteLine("Please enter some text: ");
            text = Console.ReadLine();

            return text;
        }

        //Reads the text from the specified file and returns it to the Program class
        public string FileTextInput(string fileName)
        {
            text = File.ReadAllText(fileName).ToString();
           
            return text;
        }

    }
}
