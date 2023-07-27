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
        public String? userText { get; set; }

        public List<String> dictionary { get; }

        //Constructor, initialize variables
        public Game(bool c = false, int g = 0, String? input = "")
        {
            correct = c;
            guesses = g;
            userText = input;
            dictionary= wordBank();
        }
        
        //could replace repeated instance of these strings
      public String cleanString(String originalString) 
        {
            return originalString.ToLower().Replace(" ", "");

        }
      
        

        //initialize list based on input text file, load data
        public List<String> wordBank()
        {
            //initialize variables used in loop
            bool fileReached = false;
            int userFile = 0;
            List<String> dictionary = new List<String>();


            //continues loop until file is successfully reached
            while (!fileReached)
            {

                Console.WriteLine("Pick a number based on the following word banks you wish to guess from:");
                Console.WriteLine("1. Candy");
                userFile = int.Parse(Console.ReadLine());
                //ask for user input on text file, display text options
                //end user text ask

                Console.WriteLine("Searching for text file");

                //get text file based on user input
                switch (userFile)
                {
                    case 1: //text file options
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


                    case 0: //text file options
                        {

                            break;
                        }
                    case -1: //text file options
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


        public void guessing()
        {
            

        }
       




    }
}

