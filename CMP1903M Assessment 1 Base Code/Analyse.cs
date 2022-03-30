using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
        //Handles the analysis of text

        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public List<int> AnalyseText(string input)
        {
            //List of integers to hold the first five measurements:
            //1. Number of sentences
            int numSentences;
            //2. Number of vowels
            int numVowels;
            //3. Number of consonants
            int numConsonants;
            //4. Number of upper case letters
            int numUpper;
            //5. Number of lower case letters
            int numLower;
            
            //Creates a new list to store the measurements
            var values = new List<int>();

            //Initialise all the values in the list to '0'
            for(int i = 0; i<5; i++)
            {
                values.Add(0);
            }

            //Runs the AnalyseSentences function and sets the value of the numSentences variable to the output
            numSentences = AnalyseSentences(input);
            //Sets the first item in the list to the value of numSentences
            values[0] = numSentences;

            //Runs the AnalyseVowels function and sets the value of the numVowels variable to the output
            numVowels = AnalyseVowels(input);
            //Sets the second item in the list to the value of numVowels
            values[1] = numVowels;

            //Runs the AnalyseConsonants function and sets the value of the numConsonants variable to the output
            numConsonants = AnalyseConsonants(input);
            //Sets the third item in the list to the value of numConsonants
            values[2] = numConsonants;

            //Runs the AnalyseUpper function and sets the value of the numUpper variable to the output
            numUpper = AnalyseUpper(input);
            //Sets the fourth item in the list to the value of numUpper
            values[3] = numUpper;

            //Runs the AnalyseLower function and sets the value of the numLower variable to the output
            numLower = AnalyseLower(input);
            //Sets the fifth item in the list to the value of numLower
            values[4] = numLower;

            //Returns the value to where it was called in the Program class
            return values;
        }

        //Counts the number of full stops, exclamation marks, and question marks there are in the text
        static int AnalyseSentences(string input)
        {
            int numSentences = 0;
            char[] chars = input.ToCharArray();

            for(int i = 0; i<chars.Length; i++)
            {
                if(chars[i].ToString() == "." || chars[i].ToString() == "!" || chars[i].ToString() == "?")
                {
                    numSentences += 1;
                }
            }

            return numSentences;
        }

        //Counts the number of lower-case and upper-case vowels there are in the text
        static int AnalyseVowels(string input)
        {
            int numVowels = 0;
            char[] chars = input.ToCharArray();

            for(int i=0; i<chars.Length; i++)
            {
                string s = chars[i].ToString();
                if(s == "a" || s == "A" || s == "e" || s == "E" || s == "i" || s == "I" || s == "o" || s == "O" || s == "u" || s ==  "U")
                {
                    numVowels += 1;
                }
            }

            return numVowels;
        }

        //Counts the number of lower-case and upper-case consonants there are in the text
        static int AnalyseConsonants(string input)
        {
            int numConsonants = 0;
            char[] chars = input.ToCharArray();

            for(int i=0; i<chars.Length; i++)
            {
                string s = chars[i].ToString();
                if(s == "b" || s == "B" || s == "c" || s == "C" || s == "d" || s == "D" || s == "f" || s == "F" || s == "g" || s == "G" || s == "h" || s == "H" || s == "j" || s == "J" || s == "k" || s == "K" || s == "l" || s == "L" || s == "m" || s == "M" || s == "n" || s == "N" || s == "p" || s == "P" || s == "q" || s == "Q" || s == "r" || s == "R" || s == "s" || s == "S" || s == "t" || s == "T" || s == "v" || s == "V" || s == "w" || s == "W" || s == "x" || s == "X" || s == "y" || s == "Y" || s == "z" || s == "Z")
                {
                    numConsonants += 1;
                }
            }

            return numConsonants;
        }

        //Counts the number of upper-case letters there are in the text
        static int AnalyseUpper(string input)
        {
            int numUpper = 0;
            char[] chars = input.ToCharArray();

            for(int i = 0; i < chars.Length; i++)
            {
                string s = chars[i].ToString();
                if(s == "A" || s == "B" || s == "C" || s == "D" || s == "E" || s == "F" || s == "G" || s == "H" || s == "I" || s == "J" || s == "K" || s == "L" || s == "M" || s == "N" || s == "O" || s == "P" || s == "Q" || s == "R" || s == "S" || s == "T" || s == "U" || s == "V" || s == "W" || s == "X" || s == "Y" || s == "Z")
                {
                    numUpper +=1;
                }
            }

            return numUpper;
        }

        //Counts the number of lower-case letters there are in the text
        static int AnalyseLower(string input)
        {
            int numLower = 0;
            char[] chars = input.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                string s = chars[i].ToString();
                if (s == "a" || s == "b" || s == "c" || s == "d" || s == "e" || s == "f" || s == "g" || s == "h" || s == "i" || s == "j" || s == "k" || s == "l" || s == "m" || s == "n" || s == "o" || s == "p" || s == "q" || s == "r" || s == "s" || s == "t" || s == "u" || s == "v" || s == "w" || s == "x" || s == "y" || s == "z")
                {
                    numLower += 1;
                }
            }

            return numLower;
        }
    }
}
