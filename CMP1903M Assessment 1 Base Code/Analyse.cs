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

        char[] lowerVowels = {'a','e','i','o','u'};
        char[] upperVowels = {'A','E','I','O','U'};
        char[] lowerConsonant = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z'};
        char[] upperConsonant = { 'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'X', 'Y', 'Z'};
        char sentences = '.';

        int numOfSentences = 0;
        int numOfVowels = 0;
        int numOfConsonants = 0;
        int numOfUpperCase = 0;
        int numOfLowerCase = 0;
        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public List<int> analyseText(string input)
        {
            //List of integers to hold the first five measurements:
            //1. Number of sentences
            //2. Number of vowels
            //3. Number of consonants
            //4. Number of upper case letters
            //5. Number of lower case letters
            List<int> values = new List<int>();
            //Initialise all the values in the list to '0'
            for(int i = 0; i<5; i++)
            {
                values.Add(0);
            }

            foreach (char character in input)
            {
                if (character == sentences)
                {
                    numOfSentences++;
                }
                else if (lowerVowels.Contains(character))
                {
                    numOfLowerCase++;
                    numOfVowels++;
                }
                else if (upperVowels.Contains(character))
                {
                    numOfUpperCase++;
                    numOfVowels++;
                }
                else if (lowerConsonant.Contains(character))
                {
                    numOfLowerCase++;
                    numOfConsonants++;
                }
                else if (upperConsonant.Contains(character))
                {
                    numOfUpperCase++;
                    numOfConsonants++;
                }
            }

            Console.WriteLine(numOfSentences);
            Console.WriteLine(numOfVowels);
            Console.WriteLine(numOfConsonants);
            Console.WriteLine(numOfUpperCase);
            Console.WriteLine(numOfLowerCase);

            return values;
        }
    }
}
