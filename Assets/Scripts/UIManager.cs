using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject soundBtn;
    [SerializeField] private GameObject homeBtn;
    [SerializeField] private GameObject questionBtn;

    private bool isSetting;
    private bool isClick;

    public void ClickSettingButton()
    {
        if (isSetting) return;
        isSetting = !isSetting;

        if(isSetting)
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
