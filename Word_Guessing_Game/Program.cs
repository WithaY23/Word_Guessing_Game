// See https://aka.ms/new-console-template for more information

/*Create Word Guessing Game: 
 * Load from text file (Allows for different words, ex: sports list, health list, school list)
 * Generate Random Word via Random and List Index (Load text file into List; allows for different words)
 * Allow for user feedback and loop for multiple uses, keeps count of attempts
 */



//load data from list for a word
List<String> dictionary = new List<String>();
using (StreamReader file = new StreamReader(@"C:\Users\aebud\source\repos\Word_Guessing_Game\Word_Guessing_Game\Candy.txt"))
{
    while (!file.EndOfStream)
    {
        dictionary.Add((file.ReadLine()));
    }
}

    //set up randomness
    Random rnd = new Random();
int indexList = rnd.Next(1, dictionary.Count());


//set up variables for loop. user's word, program's word, bool for loop, number of guesses

Console.WriteLine(indexList);
String answer = dictionary[indexList];
String? userInput = "";
bool correct =  false;
int guesses = 0;


//user takes guesses for as long as they don't get the answer
while (!correct)
{

    //get input from user
    Console.WriteLine("Guess a Word: ");
    userInput = Console.ReadLine().ToLower();



    if(userInput ==  answer)
    {
        Console.WriteLine("You guessed correctly, congrats!");

    }


    else //guessed wrong, add a tick to the count, and give feedback on their answer
    {


        //their answer was "higher", tell them that
        if (String.Compare(userInput, answer) >0 )
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





}

