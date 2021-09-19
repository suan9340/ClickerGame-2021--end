using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class ButtonManager : MonoBehaviour
{
    //---------창 눌렀을 때 변수---------//
    [Header("창 눌렀을 때")]
    [SerializeField] private GameObject settingChang;

    //---------기타 등등---------//
    [Header("뒤에 클릭 막는 오브제")]
    [SerializeField] private GameObject hide;

    //---------저장---------//
    [Header("나가기변수")]
    [SerializeField] private GameObject quitImage;
    [SerializeField] private GameObject reallyQuit;
    //---------저장---------//
    [Header("저장변수")]
    [SerializeField] private GameObject saveImage;


    #region 기타등등
    private void DotClickBack()
    {
        hide.SetActive(true);
    }

    private void ClickBack()
    {
        hide.SetActive(false);
    } 
    #endregion
    #region 창 눌렀을 때
    public void ClickChang()
    {
        
        settingChang.transform.DOMove(new Vector3(0f, 0f, 0f), 1f);
        Invoke("Close", 5f);
    }

    public void Close()
    {
        Vector3 pos = new Vector3(0f, -0.6f, 0f);
        settingChang.transform.DOMove(pos, 1f);
    } 
    #endregion

    #region 나가기

    public void ClickQuit()
    {
        quitImage.SetActive(true);
        DotClickBack();
    }

    public void ClickContinue()
    {
        quitImage.SetActive(false);
        ClickBack();
    }

    public void ClcikOutGame()
    {
        reallyQuit.SetActive(true);
        DotClickBack();
    }

    public void reallyQYES()
    {
        Debug.Log("게임 종료");
        Application.Quit();
    }

    public void reallyQNO()
    {
        reallyQuit.SetActive(false);
    }

    #endregion


    #region 저장
    public void ClickSave()
    {
        //Debug.Log("저장됨");
        GameManager.Instance.SaveToJson();
        saveImage.SetActive(true);
        Invoke("A", 2f);
    }
    private void A()
    {
        saveImage.SetActive(false);
    }
    #endregion


    public void ClickjellyDoGam()
    {

    }

    public void ClickResetGame()
    {

    }

   
}
