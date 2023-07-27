// See https://aka.ms/new-console-template for more information
using Word_Guessing_Game;

/*Create Word Guessing Game: 
 * Load from text file (Allows for different words, ex: sports list, health list, school list)
 * Generate Random Word via Random and List Index (Load text file into List; allows for different words)
 * Allow for user feedback and loop for multiple uses, keeps count of attempts
 */



//load data from list for a word
//create instance of Game class to create necessary variables, initialize them

Game hello = new Game();
Console.WriteLine(hello.correct);
Console.WriteLine(hello.guesses);
Console.WriteLine(hello.userInput);
for(int i = 0; i< hello.dictionary.Count; i++)
{
    Console.WriteLine(hello.dictionary[i]);
}






//Note to self: Could create random method for beginning, not necessary
    //set up randomness
    Random rnd = new Random();
int indexList = rnd.Next(1, hello.dictionary.Count()); 
String answer= hello.dictionary[indexList];
Console.WriteLine(indexList);


//Note to self: While method, loop the method in Program.cs or method itself, either works
//user takes guesses for as long as they don't get the answer
do
{

    //get input from user, format it so that the string is lowercased and has no spaces
    Console.WriteLine("Guess a Word: ");
    hello.userInput = (Console.ReadLine().ToLower()).Replace(" ", "");



    if (hello.userInput == answer)
    {
        Console.WriteLine("You guessed correctly, congrats!");
        hello.correct = true;
    }


    else //guessed wrong, add a tick to the count, and give feedback on their answer
    {


        //their answer was "higher", tell them that
        if (String.Compare(hello.userInput, answer) > 0)
        {
            Console.WriteLine("Too far, try earlier in the alphabet.");
            hello.guesses++;
        }



        //their answer was "lower", tell them that
        else
        {
            Console.WriteLine("Too early, try farther in the alphabet.");
            hello.guesses++;
        }

    }

}while (!hello.correct);

