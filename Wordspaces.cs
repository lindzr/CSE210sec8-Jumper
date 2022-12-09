using System;
using System.Collections.Generic;
// sets underscore and space characters for hiddenWord and compares guesses to hiddenWord
// if letter isn't in hiddenWord, pop index 0 of parachute
class Wordspaces : Person
{
    public string character {get ; set;}
    string chosenWord {get; set;}
    List<string> hiddenWordList = new List<string>();
    List<string> chosenWordList = new List<string>();

    // Ask user guess, compare guess to each letter in hidden word, 
    // reveals letter if correct, 
    // removes part of parachute if letter incorrect
    // returns new hidden word
    public List<string> MakeChosenWordList() 
    {
        // setup variables: character with "_", chosenWord with Random word, and hiddenWord with characters
        
        chosenWord = Words.retrieveWord();

        foreach (char c in chosenWord)
        {
            chosenWordList.Add(c.ToString());
        }
        return chosenWordList;
    }    

    public void MakeHiddenWordList()
    {
      character = "_";
      
      foreach ( string i in chosenWordList)
        {
            hiddenWordList.Add(character);
        }
        foreach (string i in hiddenWordList)
            {Console.Write(i);} 
            
    }
    public void checkGuess(string playerguess)
    {
        for (int i = 0; i < chosenWordList.Count; i++)
        {
            if (playerguess == chosenWordList[i])
            {
                hiddenWordList[i] = playerguess;
            }
        }
        for (int j = 0; j < hiddenWordList.Count; j++)
            {
                Console.Write(hiddenWordList[j]);
            }       
    }

    public bool ContainsGuess(string playerguess)
    {
        if (hiddenWordList.Contains(playerguess))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool isGameOver(List<string> parachute)
    {
        if (parachute.Count == 0)
        {
            return true;
        }

        else if (!hiddenWordList.Contains("_"))
        {
            return true;
        }
        else if (parachute.Count > 0 && hiddenWordList.Contains("_"))
        { 
            return false;
        }
        else
        {
            return false;
        }
    }
}