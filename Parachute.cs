class Parachute
{
    List <string> parachuteList = new List <string> {"   ___" , "  /   \\" , "   ___ ", "  \\  /", "   \\ /"};

    public List<string> ParachuteList
    {
        get {return parachuteList;}
    }

    public List<string> SetParachuteList(List<string> parachuteList)
    {
        return parachuteList;
    }

}