using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

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
    [SerializeField] private GameObject settingObject;
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
    private void ResetChang()
    {
        storeObject.SetActive(false);
        settingObject.SetActive(false);
        randomObject.SetActive(false);
    }

    // �� �����Լ�
    private void ResetBool()
    {
        isStore = true;
        isRand = true;
    }
    #endregion

    #region ����

    // ������ư ������ ��
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
    
    #region ����
    // ���� ������ ��
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

    #region ����
    // ���� ������ ��
    public void ClickDoGam()
    {
        ResetChang();
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
