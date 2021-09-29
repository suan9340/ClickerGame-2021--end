using System.Collections.Generic;

[System.Serializable]
public class User 
{
    public string userName;
    public long jellyPiece;
    public long jellyPerClick; // 클릭당늘어나는수
    public long jellyPerAuto;
    public List<Jelly> jellyList=new List<Jelly>();
    public List<Item> itemList = new List<Item>();
    public List<Challenge> challengeList = new List<Challenge>();
}
