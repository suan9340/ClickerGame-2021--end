using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class ButtonManager : MonoBehaviour
{
    //---------â ������ �� ����---------//
    [Header("â ������ ��")]
    [SerializeField] private GameObject settingChang;

    //---------��Ÿ ���---------//
    [Header("�ڿ� Ŭ�� ���� ������")]
    [SerializeField] private GameObject hide;

    //---------����---------//
    [Header("�����⺯��")]
    [SerializeField] private GameObject quitImage;
    [SerializeField] private GameObject reallyQuit;
    //---------����---------//
    [Header("���庯��")]
    [SerializeField] private GameObject saveImage;


    #region ��Ÿ���
    private void DotClickBack()
    {
        hide.SetActive(true);
    }

    private void ClickBack()
    {
        hide.SetActive(false);
    } 
    #endregion
    #region â ������ ��
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

    #region ������

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
        Debug.Log("���� ����");
        Application.Quit();
    }

    public void reallyQNO()
    {
        reallyQuit.SetActive(false);
    }

    #endregion


    #region ����
    public void ClickSave()
    {
        //Debug.Log("�����");
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
