//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    static class Program
    {
        static void Main()
        {
            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();

            string prompt = "Please press:\n\n (1) to enter text manually for analysis\n (2) to analyse text from file\n Your response: ";
            string errorMessage = "\n\nInvalid Input!" + prompt;
            
            string text = "some text";

            Console.Write(prompt);
            
            //Create 'Input' object
            //Get either manually entered text, or text from a file
            Input get = new Input();
            
            while (true)
            {
                string userChoice = Console.ReadLine();
                if (userChoice == "1")
                {
                    text = get.ManualTextInput();
                    break;
                }
                else if (userChoice == "2")
                {
                    Console.Write("\n\nPlease type the name of the text file you wish to be analysed: ");
                    string fileName = Console.ReadLine();
                    text = get.FileTextInput(fileName);
                    break;
                }
                else
                {
                    Console.WriteLine(errorMessage);
                }
            }

            //Create an 'Analyse' object
            //Pass the text input to the 'analyseText' method
            Console.WriteLine(text);
            Analyse run = new Analyse();
            parameters = run.AnalyseText(text);
            
            text = get.RemovePunctuation(text);

            Report write = new Report();
            List<string> listComplexWords = new List<string>(run.ComplexWords(text));
            write.outputFile(listComplexWords,"newfile.txt");

            //Receive a list of integers back
            int numSentences = parameters[0];
            int numOfVowels = parameters[1];
            int numOfConsonants = parameters[2];
            int numOfUpperCase = parameters [3];
            int numOfLowerCase = parameters[4];
            int numOfNumerals = parameters[5];
            int numOfCharacters = parameters[6];
            
            //Report the results of the analysis
            Console.WriteLine("\nAnalysis of your Text:\n");
            Console.WriteLine($"Number of Sentences: {numSentences}\n" +
                              $"Number of Vowels: {numOfVowels}\n" +
                              $"Number of Consonants: {numOfConsonants}\n" +
                              $"Number of Upper-Case Letters: {numOfUpperCase}\n" +
                              $"Number of Lower-Case Letters: {numOfLowerCase}\n" +
                              $"Number of Numerals: {numOfNumerals}\n" +
                              $"Total number of Characters: {numOfCharacters}");
            
            //TO ADD: Get the frequency of individual letters?
            
            run.Frequency(text);
            
            
            Console.Read();
           
        }
        
    }
}
