using System.Collections.Generic;

[System.Serializable]
public class User 
{
    public string userName;
    public long fireBall;
    public long firePerClick;
    public List<Items> itemList=new List<Items>();
}
