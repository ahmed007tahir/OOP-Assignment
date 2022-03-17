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

            string prompt = "Please press:\n\n (1) to enter text manually for analysis\n (2) to analyse text from file";
            string errorMessage = "\n\nInvalid Input!" + prompt;
            Input input = new Input();

            Console.WriteLine(prompt);
            
            while (true) 
            {
                try
                {
                    string userChoice = Console.ReadLine();
                    if (userChoice == "1")
                    {
                        input.manualTextInput();
                    }
                    else if (userChoice == "2")
                    {
                        Console.WriteLine("Please type the name of the text you wish to be analysed.");
                        string fileName = Console.ReadLine();
                        input.fileTextInput(fileName);
                    }
                    else
                    {
                        Console.WriteLine(errorMessage);
                    }
                }
                catch
                {
                    Console.WriteLine(errorMessage);
                }
            }

            //Create 'Input' object
            //Get either manually entered text, or text from a file
            


            //Create an 'Analyse' object
            //Pass the text input to the 'analyseText' method


            //Receive a list of integers back


            //Report the results of the analysis


            //TO ADD: Get the frequency of individual letters?

           
        }
        
        
    
    }
}
