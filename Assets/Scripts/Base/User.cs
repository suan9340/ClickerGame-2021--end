using System.Collections.Generic;

[System.Serializable]
public class User 
{
    public string userName;
    public long jellyPiece;
    public long jellyPerClick;
    public List<Jelly> jellyList=new List<Jelly>();
}
