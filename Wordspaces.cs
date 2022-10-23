using System.Collections.Generic;
class Wordspaces
{
    string character = " _";
    public string Character {get ; set;}
    string chosenWord =  Words.retrieveWord();
    string playerGuess = "";
    List<string> hiddenWord = new List<string>();

    public List<string> blankWord()
    {
        Console.WriteLine("Please enter your guess: ");
        char playerguess = char.Parse(Console.ReadLine());
        
        for (int i = 0; i < chosenWord.Length; i++)
        {
            hiddenWord[i] = character;
        
            if (playerguess == chosenWord[i])
            {
                hiddenWord[i] = playerGuess;
            }
        }
        return hiddenWord;
    }

}