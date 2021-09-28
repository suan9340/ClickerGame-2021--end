using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    //----------- 상점 눌렀을 때 변수 -----------//
    [Header("상점 눌렀을 때")]
    [SerializeField] private GameObject storeObject;
    [SerializeField] private GameObject itemBuyChang;
    private bool isStore;

    //----------- 설정 눌렀을 때 변수 -----------//
    [Header("설정 눌렀을 때")]
    [SerializeField] private GameObject settingThis;
    private bool isSetting;
    [SerializeField] private GameObject settingObject;
    [SerializeField] private Sprite[] settingImage;

    //----------- 나가기 눌렀을 때 변수 -----------//
    [Header("나가기 눌렀을 때")]
    [SerializeField] private GameObject outGame;
    private bool isOutGame;

    [SerializeField] private GameObject setHide;

    #region 상점

    // 상점버튼 눌렀을 때
    public void ClickStore()
    {

        isStore = !isStore;
        if(isStore)
        {
            storeObject.SetActive(true);
        }
        else
        {
            storeObject.SetActive(false);
        }
        
    }

    public void OutStore()
    {
        isStore = !isStore;
        storeObject.SetActive(false);
    }

    #endregion

    #region 설정
    // 설정 눌렀을 떄
    public void ClickSetting()
    {
        isSetting = !isSetting;
        if(isSetting)
        {
            settingThis.GetComponent<Image>().sprite = settingImage[0];
            settingObject.SetActive(true);
        }
        else
        {
            settingThis.GetComponent<Image>().sprite = settingImage[1];
            settingObject.SetActive(false);
        }
    }
    #endregion

    public void ClickOutGame()
    {
        isOutGame = !isOutGame;
        if(isOutGame)
        {
            setHide.SetActive(true);
            outGame.SetActive(true);
        }
        else
        {
            setHide.SetActive(false);
            outGame.SetActive(false);  
        }
    }

    public void ClickXChang()
    {
        isOutGame = !isOutGame;
        setHide.SetActive(false);
        outGame.SetActive(false);
    }

    public void ClickOut()
    {
        Debug.Log("게임종료성공");
        Application.Quit();
    }
}
