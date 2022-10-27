class Person : Parachute
{
    List<string> personBody = new List<string> {"     O","    /|\\","    / \\","","^^^^^^^"};
    
    
    
    public void drawBody()
    {   
        bool parabool = HasMoreParachute();
        if (parabool == false)
        {
            personBody[0] = "     X";
        }

        foreach (string part in personBody)
        {
            Console.WriteLine(part);
        }
    }    

        

}