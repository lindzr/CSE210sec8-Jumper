using System.Collections.Generic;
// sets underscore and space characters for hiddenWord and compares guesses to hiddenWord
// if letter isn't in hiddenWord, pop index 0 of parachute
class Wordspaces : Parachute
{
    string character = " _";
    public string Character {get ; set;}
    string chosenWord =  Words.retrieveWord();
    string playerGuess = "";
    List<string> hiddenWord = new List<string>();

    // Ask user guess, compare guess to each letter in hidden word, 
    // reveals letter if correct, 
    // removes part of parachute if letter incorrect
    // returns new hidden word
    public List<string> blankWord()
    {
        Console.WriteLine("Please enter your guess (a-z): ");
        char playerguess = char.Parse(Console.ReadLine());
        
        for (int i = 0; i < chosenWord.Length; i++)
        {
            hiddenWord[i] = character;
        
            if (playerguess == chosenWord[i])
            {
                hiddenWord[i] = playerGuess;
            }
        }
        
        if (hiddenWord.Contains(playerGuess))
        {
            hiddenWord = hiddenWord;
        }
        else
        {
            parachuteList.RemoveAt(0);
        }
        
        return hiddenWord;
    }

}