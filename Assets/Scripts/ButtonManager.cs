using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    //----------세팅 변수----------//
    [Header("세팅 변수")]
    [SerializeField] private GameObject soundBtn;
    [SerializeField] private GameObject homeBtn;
    [SerializeField] private GameObject gameInfoBtn;
    private bool isSettingClick;

    //----------홈 눌렀을때 세팅 변수----------//
    [Header("홈 눌렀을 때 변수")]
    [SerializeField] private GameObject homeSettingChang;
    private bool isHomeSettingClick;

    //----------게임 인포 눌렀을때 세팅 변수----------//
    [Header("게임 인포 눌렀을 때 변수")]
    [SerializeField] private GameObject gameInfoChang;
    [SerializeField] private GameObject InfoOutBtn;
    private bool isGameInfoClick;

    private void TimeStop()
    {
        Time.timeScale = 0f;
    }
    private void TimeStart()
    {
        Time.timeScale = 1f;
    }
   
    #region Setting버튼
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

    #region home 눌렀을 때
    public void ClickHomeButton()
    {
        isHomeSettingClick = !isHomeSettingClick;
        if (isHomeSettingClick)
        {
            homeSettingChang.SetActive(true);
            TimeStop();
        }
        else
        {
            homeSettingChang.SetActive(false);
            TimeStart();
        }
    }

    public void ClickContinue()
    {
        isHomeSettingClick = !isHomeSettingClick;
        homeSettingChang.SetActive(false);
        TimeStart();
    }

    public void ClickGoMenu()
    {
        isHomeSettingClick = !isHomeSettingClick;
        Debug.Log("Menu로 돌아감");
        SceneManager.LoadScene("Menu");
    } 
    #endregion

    public void ClickGameInfo()
    {
        isGameInfoClick = !isGameInfoClick;
        if(isGameInfoClick)
        {
            gameInfoChang.SetActive(true);
            TimeStop();
        }
        else
        {
            gameInfoChang.SetActive(false);
            TimeStart();
        }
    }

    public void ClickOutGameInfo()
    {
        isGameInfoClick = !isGameInfoClick;
        gameInfoChang.SetActive(false);
        TimeStart();
    }
}
