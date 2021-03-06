using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoSingleTon<GameManager>
{
    private string SAVE_PATH = "";
    private string SAVE_FILENAME = "/SaveFile.txt";

    [SerializeField] private User user = null;
    public User CurrentUser { get { return user; } }
    private UIManager uiManager = null;
    public UIManager UI { get { return uiManager; } }

    private void Awake()
    {
        //SAVE_PATH = Application.dataPath + "/Save";
        SAVE_PATH = Application.persistentDataPath + "/Save";
        if (Directory.Exists(SAVE_PATH) == false)
        {
            Directory.CreateDirectory(SAVE_PATH);
        }

        InvokeRepeating("SaveToJson", 1f, 50f);
        InvokeRepeating("EarnJellyPerSecond", 0f, 1f);
        LoadFromJson();
        uiManager = GetComponent<UIManager>();
    }

   private void EarnJellyPerSecond()
    {
        foreach(Jelly jelly in user.jellyList)
        {
            user.jellyPiece += jelly.jellyPerSecond * jelly.amount;
        }
        UI.UpdateJellyPanel();
    }
    private void LoadFromJson()
    {
        string json = "";
        if (File.Exists(SAVE_PATH + SAVE_FILENAME) == true)
        {
            json = File.ReadAllText(SAVE_PATH + SAVE_FILENAME);
            user = JsonUtility.FromJson<User>(json);
        }
    }

    public void SaveToJson()
    {
        //SAVE_PATH = Application.dataPath + "/Save";
        SAVE_PATH = Application.persistentDataPath + "/Save";
        string json = JsonUtility.ToJson(user, true);
        File.WriteAllText(SAVE_PATH + SAVE_FILENAME, json, System.Text.Encoding.UTF8);
    }
                                                  
    public void ResetEvery()
    {
        CurrentUser.jellyPerAuto = 0;
        CurrentUser.jellyPerClick = 1;
        CurrentUser.jellyPiece = 0;

        UI.UpdateJellyPanel();
        SaveToJson();
        UI.UpdateJellyPanel();

    }

    private void OnApplicationQuit()
    {
        SaveToJson();
    }
}
