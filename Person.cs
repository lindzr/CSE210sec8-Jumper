using System.Collections.Generic;

class Person
{
    private static string [] personPieces = {"  O"," /|\\"," / \\","","^^^^^^^"};
    List<string> person = new List<string>(personPieces);

    public void DrawBody()
    { 
        foreach (string i in person)
        {
            Console.WriteLine(i);
        }
    }
}