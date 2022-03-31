using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        //Handles the text input for Assessment 1
        
        //Initialising private variable to hold the Text
        private string _text = "some-text";
        
        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public string ManualTextInput()
        {

            Console.WriteLine("\nType in the Text. Please end with an asterisk(*).\n");
            try
            {
                _text = Console.ReadLine();
                while (_text[_text.Count() - 1] != '*')
                {
                    Console.WriteLine(
                        "\nYou did not end your text with an asterisk(*). You can continue to type in more text.\nPlease end your text with an asterisk(*).");
                    _text += " ";
                    _text += Console.ReadLine();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            catch
            {
                Console.WriteLine("Invalid Input");
                ManualTextInput();
            }
            return _text;
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public string FileTextInput(string fileName)
        {
            string errorMessage = "Please type the name of the text you wish to be analysed: ";
            while (true)
            {
                try
                {
                    _text = File.ReadAllText($@"../../../../Text Files Go HERE/{fileName}");
                    break;
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine(
                        $"File with the name '{fileName}' doesn't exist in the 'Text Files Go HERE' folder.");
                    Console.Write(errorMessage);
                    FileTextInput(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Invalid Input!");
                    Console.Write(errorMessage);
                    FileTextInput(Console.ReadLine());
                    break;
                }
            }
            return _text;
        }

        // function that takes in a string text and returns the text with all the punctuation removed
        public string RemovePunctuation(string text)
        {
            var sb = new StringBuilder();
            foreach (char i in text)
            {
                if (!char.IsPunctuation(i))
                    sb.Append(i);
            }
            return sb.ToString();
        }

    }
}
