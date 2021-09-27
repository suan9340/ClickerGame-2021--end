using System.Collections.Generic;

[System.Serializable]
public class User 
{
    public string userName;
    public long jellyPiece;
    public long jellyPerClick;
    public long jellyPerAuto;
    public List<Jelly> jellyList=new List<Jelly>();
    public List<Item> itemList = new List<Item>();
}
