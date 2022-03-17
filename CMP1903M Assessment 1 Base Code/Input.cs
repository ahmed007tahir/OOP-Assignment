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
        string text = "nothing";
        
        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public string manualTextInput()
        {

            string prompt = "Please type in the text you wish to be analysed.";
            string errorMessage = "Invalid input!" + prompt;

            Console.WriteLine(prompt);

            while (true)
            {
                try
                {
                    text = Console.ReadLine();
                    Console.WriteLine(errorMessage);
                    break;
                    
                }
                catch
                {
                    Console.WriteLine(errorMessage);
                }
            }

            return text;
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public string fileTextInput(string fileName)
        {

            string errorMessage = "Invalid input! Please type the name of the text you wish to be analysed.";

            while (true)
            {
                try
                {
                    text = System.IO.File.ReadAllText($@"/Text Files Go HERE/{fileName}");
                    break;
                }
                catch
                {
                    Console.WriteLine(errorMessage);
                    fileTextInput(Console.ReadLine());
                }
            }
            return text;
        }

    }
}
