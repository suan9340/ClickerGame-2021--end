using System.Collections.Generic;

[System.Serializable]
public class User 
{
    public string userName;
    public long jellyPiece;
    public long jellyPerClick; // Ŭ����þ�¼�
    public long jellyPerAuto;
    public List<Jelly> jellyList=new List<Jelly>();
    public List<Item> itemList = new List<Item>();
    public List<Challenge> challengeList = new List<Challenge>();
}
