using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    //----------- ���� ������ �� ���� -----------//
    [Header("���� ������ ��")]
    [SerializeField] private GameObject storeObject;
    [SerializeField] private GameObject itemBuyChang;
    private bool isStore;

    //----------- ���� ������ �� ���� -----------//
    [Header("���� ������ ��")]
    [SerializeField] private GameObject settingThis;
    private bool isSetting;
    [SerializeField] private GameObject settingObject;
    [SerializeField] private Sprite[] settingImage;

    //----------- ������ ������ �� ���� -----------//
    [SerializeField] private GameObject outGame;
    private bool isOutGame;

    #region ����

    // ������ư ������ ��
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

    #region ����
    // ���� ������ ��
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
            outGame.SetActive(true);
        }
        else
        {
            outGame.SetActive(false);  
        }
    }

    public void ClickXChang()
    {
        isOutGame = !isOutGame;
        outGame.SetActive(false);
    }

    public void ClickOut()
    {
        Debug.Log("�������Ἲ��");
        Application.Quit();
    }
}
