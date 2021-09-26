using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    //----------- �ڿ� Ŭ�� ���ϰ� �ϴ� ���� -----------//
    [Header("�ڿ� Ŭ�� ���� ������Ʈ")]
    [SerializeField] private GameObject hideChang;

    //----------- ���� ������ �� ���� -----------//
    [Header("���� ������ ��")]
    [SerializeField] private GameObject storeObject;
    [SerializeField] private GameObject itemBuyChang;
    [SerializeField] private GameObject coinBuyChang;
    private bool isStore;

    //----------- ���� ������ �� ���� -----------//
    [Header("���� ������ ��")]
    [SerializeField] private GameObject settingThis;
    [SerializeField] private GameObject settingObject;
    [SerializeField] private Sprite[] settingImage;
    private bool isSetting;

    //----------- �̱� ������ �� ���� -----------//
    [Header("�̱� ������ ��")]
    [SerializeField] private GameObject randomObject;
    private bool isRand;


    //----------- ���� ������ �� ���� -----------//
    [Header("���� ������ ��")]
    [SerializeField] private GameObject doGamObject;
    private bool isDoGam;
    #region Ŭ������
    // �ڿ� Ŭ�� ���� �Լ�
    private void DonClickBack()
    {
        hideChang.SetActive(true);
    }

    // �ڿ� Ŭ�� ���� �Լ�
    private void CanClickBack()
    {
        hideChang.SetActive(false);
    } 
    
    // �ٸ� â �����Լ�
   
    #endregion

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

    // ���� �ȿ��� ������ ���� ������ ��
    public void ClickItemChang()
    {
        coinBuyChang.SetActive(false);
        itemBuyChang.SetActive(true);
    }

    // ���� �ȿ��� ���� ���� ������ ��
    public void ClickCoinChang()
    {
        itemBuyChang.SetActive(false);
        coinBuyChang.SetActive(true);
    }

    // ���� ������ ��ư ������ ��
    //public void ClickOutStore()
    //{
    //    isStore = !isStore;
    //    CanClickBack();
    //    storeObject.SetActive(false);
    //}

    #endregion

    #region �����̱�
    // �����̱� ������ ��
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

    #region ����
    // ���� ������ ��
    public void ClickDoGam()
    {
        DonClickBack();
        doGamObject.SetActive(true);
       
    }

    // ���� ������ ������ ��
    public void ClickOutDoGam()
    {
        CanClickBack();
        doGamObject.SetActive(false);
    }
    #endregion
}
