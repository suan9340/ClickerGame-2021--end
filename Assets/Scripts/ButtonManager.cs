using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

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
    [SerializeField] private GameObject settingObject;
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
    private void ResetChang()
    {
        storeObject.SetActive(false);
        settingObject.SetActive(false);
        randomObject.SetActive(false);
    }

    // 불 리셋함수
    private void ResetBool()
    {
        isStore = true;
        isRand = true;
    }
    #endregion

    #region 상점

    // 상점버튼 눌렀을 때
    public void ClickStore()
    {
        ResetChang();

        isStore = !isStore;
        if(isStore)
        {
            DonClickBack();
            storeObject.SetActive(true);
        }
        else
        {
            CanClickBack();
            storeObject.SetActive(false);
        }
        
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
        ResetChang();

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
        ResetChang();

        isSetting = !isSetting;
        if(isSetting)
        {
            DonClickBack();
            settingObject.SetActive(true);
        }
        else
        {
            CanClickBack();
            settingObject.SetActive(false);
        }
    }
    #endregion

    #region 도감
    // 도감 눌렀을 때
    public void ClickDoGam()
    {
        ResetChang();
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
