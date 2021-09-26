using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    //----------- 뒤에 클릭 못하게 하는 변수 -----------//
    [Header("뒤에 클릭 방지 오브젝트")]
    [SerializeField] private GameObject hideChang;

    //----------- 상점 눌렀을 때 변수 -----------//
    [Header("상점 눌렀을 때")]
    [SerializeField] private GameObject storeObject;
    [SerializeField] private GameObject itemBuyChang;
    [SerializeField] private GameObject coinBuyChang;
    private bool isStore;

    //----------- 설정 눌렀을 때 변수 -----------//
    [Header("설정 눌렀을 때")]
    [SerializeField] private GameObject settingThis;
    [SerializeField] private GameObject settingObject;
    [SerializeField] private Sprite[] settingImage;
    private bool isSetting;

    //----------- 뽑기 눌렀을 때 변수 -----------//
    [Header("뽑기 눌렀을 때")]
    [SerializeField] private GameObject randomObject;
    private bool isRand;


    //----------- 도감 눌렀을 때 변수 -----------//
    [Header("도감 눌렀을 때")]
    [SerializeField] private GameObject doGamObject;
    private bool isDoGam;
    #region 클릭제한
    // 뒤에 클릭 방지 함수
    private void DonClickBack()
    {
        hideChang.SetActive(true);
    }

    // 뒤에 클릭 가능 함수
    private void CanClickBack()
    {
        hideChang.SetActive(false);
    } 
    
    // 다른 창 리셋함수
   
    #endregion

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

    // 상점 안에서 아이템 구매 눌렀을 때
    public void ClickItemChang()
    {
        coinBuyChang.SetActive(false);
        itemBuyChang.SetActive(true);
    }

    // 상점 안에서 코인 구매 눌렀을 때
    public void ClickCoinChang()
    {
        itemBuyChang.SetActive(false);
        coinBuyChang.SetActive(true);
    }

    // 상점 나가기 버튼 눌렀을 때
    //public void ClickOutStore()
    //{
    //    isStore = !isStore;
    //    CanClickBack();
    //    storeObject.SetActive(false);
    //}

    #endregion

    #region 랜덤뽑기
    // 랜덤뽑기 눌렀을 때
    public void ClickRandom()
    {

        isRand = !isRand;
        if(isRand)
        {
            DonClickBack();
            randomObject.SetActive(true);
        }
        else
        {
            CanClickBack();
            randomObject.SetActive(false);
        }
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

    #region 도감
    // 도감 눌렀을 때
    public void ClickDoGam()
    {
        DonClickBack();
        doGamObject.SetActive(true);
       
    }

    // 도감 나가기 눌렀을 때
    public void ClickOutDoGam()
    {
        CanClickBack();
        doGamObject.SetActive(false);
    }
    #endregion
}
