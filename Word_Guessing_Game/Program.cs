// See https://aka.ms/new-console-template for more information

/*Create Word Guessing Game: 
 * Load from text file (Allows for different words, ex: sports list, health list, school list)
 * Generate Random Word via Random and List Index (Load text file into List; allows for different words)
 * Allow for user feedback and loop for multiple uses, keeps count of attempts
 */



//load data from list for a word
//Note to self: Create dictionary add method that adds a text file to dictionary based on user input
List<String> dictionary = new List<String>();
using (StreamReader file = new StreamReader(@"C:\Users\aebud\source\repos\Word_Guessing_Game\Word_Guessing_Game\Candy.txt"))
{
    //Read data till file ends and add it to the dictionary, convert it so that the info has no spaces and is lowercased
    //DO NOT CHANGE FILES DIRECTLY FOR EFFICIENCY: Accounts for new text files to be formatted with uppercase and spaces
    while (!file.EndOfStream)
    {
        dictionary.Add((file.ReadLine().ToLower().Replace(" ", "")));
    }
}

//Note to self: Could create random method for beginning, not necessary
    //set up randomness
    Random rnd = new Random();
int indexList = rnd.Next(1, dictionary.Count());

//Note to self: Constructor?
//set up variables for loop. user's word, program's word, bool for loop, number of guesses
Console.WriteLine(indexList);
String answer = dictionary[indexList];
String? userInput = "";
bool correct =  false;
int guesses = 0;


//Note to self: While method, loop the method in Program.cs or method itself, either works
//user takes guesses for as long as they don't get the answer
do
{

    //get input from user, format it so that the string is lowercased and has no spaces
    Console.WriteLine("Guess a Word: ");
    userInput = (Console.ReadLine().ToLower()).Replace(" ", "");



    if (userInput == answer)
    {
        Console.WriteLine("You guessed correctly, congrats!");
        correct = true;
    }


    else //guessed wrong, add a tick to the count, and give feedback on their answer
    {


        //their answer was "higher", tell them that
        if (String.Compare(userInput, answer) > 0)
        {
            Console.WriteLine("Too far, try earlier in the alphabet.");
            guesses++;
        }



        //their answer was "lower", tell them that
        else
        {
            Console.WriteLine("Too early, try farther in the alphabet.");
            guesses++;
        }

    }





}while (!correct);

