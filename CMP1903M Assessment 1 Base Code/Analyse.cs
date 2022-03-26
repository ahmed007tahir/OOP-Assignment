using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
        // Handles the analysis of text

        // Initialize a list of characters to test the text against for analysis
        private readonly char[] _lowerVowels = {'a', 'e', 'i', 'o', 'u'};
        private readonly char[] _upperVowels = {'A', 'E', 'I', 'O', 'U'};
        private readonly char[] _lowerConsonant =
            {'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z'};
        private readonly char[] _upperConsonant =
            {'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'X', 'Y', 'Z'};
        private readonly char[] _numerals = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
        private readonly char[] _sentences = {'.', '!', '?'};

        // Initialise Counters to keep track of text properties
        private int _numOfSentences = 0;
        private int _numOfVowels = 0;
        private int _numOfConsonants = 0;
        private int _numOfUpperCase = 0;
        private int _numOfLowerCase = 0;
        private int _numOfNumerals = 0;
        private int _numOfCharacters = 0;
        
        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public List<int> AnalyseText(string input)
        {
            //List of integers to hold the first five measurements:
            //1. Number of sentences
            //2. Number of vowels
            //3. Number of consonants
            //4. Number of upper case letters
            //5. Number of lower case letters
            //6. Number of numerals
            //7. Number of characters
            
            List<int> values = new List<int>();
            
            //Initialise all the values in the list to '0'
            for(int i = 0; i<7; i++)
            {
                values.Add(0);
            }
            
            foreach (char character in input)
            {
                // add switch case statements here
                if (_sentences.Contains(character))
                {
                    _numOfSentences++;
                }
                else if (_lowerVowels.Contains(character))
                {
                    _numOfLowerCase++;
                    _numOfVowels++;
                }
                else if (_upperVowels.Contains(character))
                {
                    _numOfUpperCase++;
                    _numOfVowels++;
                }
                else if (_lowerConsonant.Contains(character))
                { 
                    _numOfLowerCase++;
                    _numOfConsonants++;
                }
                else if (_upperConsonant.Contains(character))
                {
                    _numOfUpperCase++;
                    _numOfConsonants++;
                }
                else if (_numerals.Contains(character))
                {
                    _numOfNumerals++;
                }
            }
            
            // Calculate the total number of Characters in the Text
            _numOfCharacters = _numOfConsonants + _numOfVowels + _numOfNumerals;

            // Assign the values of each counter to the list that is returned
            values[0] = _numOfSentences;
            values[1] = _numOfVowels;
            values[2] = _numOfConsonants;
            values[3] = _numOfUpperCase;
            values[4] = _numOfLowerCase;
            values[5] = _numOfNumerals;
            values[6] = _numOfCharacters;
                
            return values;
        }

        // Method to count the frequency of each variable in a string text
        public void Frequency(string text)
        {
            Console.WriteLine("\nThe Frequency of the text is:\n");
            while (text.Length > 0) {
                Console.Write("Character " + text[0] + ": ");
                int cal = 0;
                for (int j = 0; j < text.Length; j++) {
                    if (text[0] == text[j]) {
                        cal++;
                    }
                }
                Console.WriteLine(cal + " times");
                
                // removes the first character in string text, reducing length by 1
                text = text.Replace(text[0].ToString(), string.Empty);
            }
            // Console.ReadLine();
        }

        public List<string> ComplexWords(string text)
        {
            List<string> listComplex = new List<string>();

            foreach (string complexWord in text.Split())
            {
                if (text.Length >= 7)
                {
                    listComplex.Add(text);
                    Console.WriteLine(text);
                }
            }

            return listComplex;
        }
    }
}
