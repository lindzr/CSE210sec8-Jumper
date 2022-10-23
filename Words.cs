// Ask for difficulty and picks random word from wordbanks

class Words
{
    static public string retrieveWord()
    {
        Random generator = new Random();
        {
            List <string> wordbank = new List<string>(){"reach","heart","tiger","football"};
            int wordbankIndex = generator.Next(wordbank.Count);
            return (wordbank[wordbankIndex]);
        }

    }
}