class Parachute
{
     protected List <string> parachuteList = new List <string> {"   ___" , "  /   \\" , "   ___ ", "  \\  /", "   \\ /"};

    public bool HasMoreParachute()
    {
        List<string> parachute = parachuteList;

        int paracount = parachute.Count;

        if (paracount > 0)
        {
            for(int i = 0; i < parachute.Count(); i++)
            {
                Console.WriteLine(parachute[i]);
            }
            return true;
        }

        else
        {
            return false;
        }
    }
}