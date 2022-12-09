class Program
{
    static void Main(string[] args)
    {
        Wordspaces wordspace = new Wordspaces();
        Person person = new Person();
        Parachute parachute = new Parachute();
        List<string> parachuteListObj = parachute.GetParachuteList();
       
        // word we're trying to guess broken into a list of strings
        List<string> chosenWord = wordspace.MakeChosenWordList();
        
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Welcome to the Jumper Game! Please enter all letters in lower case.");
        Console.WriteLine("");
        Console.WriteLine("");

        // First, print the hidden word. For every index in chosenWordList, make a _
        
        wordspace.MakeHiddenWordList();
        Console.WriteLine("");

        // Then print the parachute and person
        parachute.DrawParachute(parachuteListObj);
        person.DrawBody();
        
       while (wordspace.isGameOver(parachuteListObj) == false)
        {
            // Ask for the guess
            Console.WriteLine("Please enter your guess (a-z): ");
            string playerguess = Console.ReadLine()??"";
            
            // checked the guess against the chosen word and reprint hidden word
            wordspace.checkGuess(playerguess);
            if (wordspace.ContainsGuess(playerguess) == false)
            {
                parachuteListObj.RemoveAt(0);
            }

            //check parachute and reprint parachute+person
            Console.WriteLine("");
            parachute.DrawParachute(parachuteListObj);
            person.DrawBody();

            //check if game is over
            wordspace.isGameOver(parachuteListObj);
        }

        if (parachuteListObj.Count == 0)
            {
                Console.WriteLine("You lose. Game Over.");
            }
        else
        {
            Console.WriteLine("Congratulations! You win!");
        }    
    }
}