using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    //----------���� ����----------//
    [Header("���� ����")]
    [SerializeField] private GameObject soundBtn;
    [SerializeField] private GameObject homeBtn;
    [SerializeField] private GameObject gameInfoBtn;
    private bool isSettingClick;

    //----------Ȩ �������� ���� ����----------//
    [Header("Ȩ ������ �� ����")]
    [SerializeField] private GameObject homeSettingChang;
    private bool isHomeSettingClick;

    //----------���� ���� �������� ���� ����----------//
    [Header("���� ���� ������ �� ����")]
    [SerializeField] private GameObject gameInfoChang;
    [SerializeField] private GameObject InfoOutBtn;
    private bool isGameInfoClick;


    #region Setting��ư
    public void ClickSettingButton()
    {
        isSettingClick = !isSettingClick;

        if (isSettingClick)
        {
            ShowSetting();
        }
        else
        {
            HideSetting();
        }
    }

    private void ShowSetting()
    {
        soundBtn.SetActive(true);
        homeBtn.SetActive(true);
        gameInfoBtn.SetActive(true);
    }

    private void HideSetting()
    {
        soundBtn.SetActive(false);
        homeBtn.SetActive(false);
        gameInfoBtn.SetActive(false);
    }
    #endregion

    #region home ������ ��
    public void ClickHomeButton()
    {
        isHomeSettingClick = !isHomeSettingClick;
        if (isHomeSettingClick)
        {
            homeSettingChang.SetActive(true);
        }
        else
        {
            homeSettingChang.SetActive(false);
        }
    }

    public void ClickContinue()
    {
        isHomeSettingClick = !isHomeSettingClick;
        homeSettingChang.SetActive(false);
    }

    public void ClickGoMenu()
    {
        isHomeSettingClick = !isHomeSettingClick;
        SceneManager.LoadScene("Menu");
    } 
    #endregion

    public void ClickGameInfo()
    {
        isGameInfoClick = !isGameInfoClick;
        if(isGameInfoClick)
        {
            gameInfoChang.SetActive(true);
        }
        else
        {
            gameInfoChang.SetActive(false);
        }
    }

    public void ClickOutGameInfo()
    {
        isGameInfoClick = !isGameInfoClick;
        gameInfoChang.SetActive(false);
    }
}
