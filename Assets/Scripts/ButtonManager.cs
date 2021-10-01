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
    [Header("������ ������ ��")]
    [SerializeField] private GameObject outGame;
    private bool isOutGame;

    [Header("�ʱ�ȭ ������ ��")]
    [SerializeField] private GameObject ReturnGame;
    private bool isReturnGame;

    [Header("�Ҹ�")]
    [SerializeField] private Slider slider;

    [SerializeField] private GameObject setHide;

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

    private void Update()
    {
        KeyInput();
    }

    private void KeyInput()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ClickOutGame();
        }
    }
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
        Debug.Log("�������Ἲ��");
        Application.Quit();
    }

    public void OnClickReTryGame()
    {
        isReturnGame = !isReturnGame;
        if(isReturnGame)
        {
            ReturnGame.SetActive(true);
            outGame.SetActive(true);
        }
        else
        {
            ReturnGame.SetActive(false);
            outGame.SetActive(false);
        }
    }

    public void ClickYesReTry()
    {
        Debug.Log("�����Լ������־����");
        //GameManager.Instance.ResetEvery();
    }

    public void ClickNoReTry()
    {
        isReturnGame = !isReturnGame;
        ReturnGame.SetActive(false);
        outGame.SetActive(false);
    }

    public void SliderValueSet(AudioSource _audio)
    {

        slider.value = _audio.volume;
    }
}
