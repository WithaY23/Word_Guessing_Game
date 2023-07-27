using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Guessing_Game
{
    public class Game
    {
        //variables for class, don't need anything other than dictionary and user input, could move to program
        public bool correct { get; set; } 
        public int guesses { get; set; }
        public String? userInput { get; set; }

        public List<String> dictionary { get; }

        //Constructor, initialize variables
        public Game(bool c = false, int g = 0, String? input = "")
        {
            correct = c;
            guesses = g;
            userInput = input;
            dictionary= wordBank();
        }
        
        
      
      
        

        //initialize list based on input text file, load data
        public List<String> wordBank()
        {
            //initialize variables used in loop
            bool fileReached = false;
            String userText = "";
            List<String> dictionary = new List<String>();
            //continues loop until file is successfully reached
            while (!fileReached)
            {
                //ask for user input on text file TO LOWER, display text options
                //end user text ask

                Console.WriteLine("Searching for text file");

                //get text file based on user input
                switch (userText)
                {
                    case "": //text file options
                        {
                            Console.WriteLine("Found Candy text file, loading data now");
                            using (StreamReader file = new StreamReader(@"C:\Users\aebud\source\repos\Word_Guessing_Game\Word_Guessing_Game\Candy.txt"))
                            {
                                //Read data till file ends and add it to the dictionary, convert it so that the info has no spaces and is lowercased
                                //DO NOT CHANGE FILES DIRECTLY FOR EFFICIENCY: Accounts for new text files to be formatted with uppercase and spaces
                                while (!file.EndOfStream)
                                {
                                    dictionary.Add(file.ReadLine().ToLower().Replace(" ", ""));
                                }
                            }
                            Console.WriteLine("Successfully loaded data");
                            fileReached = true;
                            break;
                        }


                    case " ": //text file options
                        {

                            break;
                        }
                    case "  ": //text file options
                        {

                            break;
                        }

                    default: //nothing was found, ask user for input again
                        {


                            break;
                        }

                }
            }
            

            return dictionary;
        }



       




    }
}

