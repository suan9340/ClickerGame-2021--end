using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] private GameObject soundBtn;
    [SerializeField] private GameObject homeBtn;
    [SerializeField] private GameObject questionBtn;
    
    private bool isSettingClick;

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
        questionBtn.SetActive(true);
    }

    private void HideSetting()
    {
        soundBtn.SetActive(false);
        homeBtn.SetActive(false);
        questionBtn.SetActive(false);
    }
}
