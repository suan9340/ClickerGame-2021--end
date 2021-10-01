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

    [Header("초기화 눌렀을 떄")]
    [SerializeField] private GameObject ReturnGame;
    private bool isReturnGame;

    [Header("소리")]
    [SerializeField] private Slider slider;

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
        Debug.Log("게임종료성공");
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
        Debug.Log("리셋함수여따넣어야함");
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
