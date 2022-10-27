class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Welcome to the Jumper Game! Please enter all letters in lower case.");
        Console.WriteLine("");
        Console.WriteLine("");

        Wordspaces wordspace = new Wordspaces();
        List<string> guessingWord = wordspace.blankWord();
    }
}