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
            
            string something = "something";

            Console.WriteLine(prompt);
            
            //Create 'Input' object
            //Get either manually entered text, or text from a file
            Input get = new Input();
            
            string userChoice = Console.ReadLine();
            if (userChoice == "1")
            {
                get.manualTextInput();
            }
            else if (userChoice == "2")
            {
                Console.WriteLine("Please type the name of the text file you wish to be analysed.");
                string fileName = Console.ReadLine();
                something = get.fileTextInput(fileName);
            }
            else
            {
                Console.WriteLine(errorMessage);
            }


            //Create an 'Analyse' object
            //Pass the text input to the 'analyseText' method
            Console.WriteLine(something);
            Analyse run = new Analyse();
            run.analyseText(something);


            //Receive a list of integers back


            //Report the results of the analysis


            //TO ADD: Get the frequency of individual letters?
            Console.Read();
           
        }
        
        
    
    }
}
