class Person
{
    List<string> personBody = new List<string> {"     O","    /|\\","    / \\","","^^^^^^^"};
    Parachute parachute = new Parachute();
    List<string> parachuteList = Parachute.ParachuteList
    public void GetParachuteList()
    {
        List<string> parachutePieces = parachute.GetParachuteList();

        int paracount = parachutePieces.Count;

        if (paracount > 0)
        {
            for(int i = 0; i < parachutePieces.Count(); i++)
            {
                Console.WriteLine(parachutePieces[i]);
            }
        }
    }
    public void drawBody()
    {
        if (HasMoreParachute() == false)
        {
            personBody[0] = "     X";
        }
        
        foreach (string part in personBody)
        {
            Console.WriteLine(part);
        }
    }    

    

}