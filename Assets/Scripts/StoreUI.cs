using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreUI : MonoBehaviour
{
    [SerializeField] private GameObject store;
    //----------�������� ����----------//
    [SerializeField] private GameObject jellyBuyChang;
    private bool isJellyBuy;

    //----------�����۱��� ����----------//
    [SerializeField] private GameObject itemBuyChang;
    private bool isItemBuy;

    #region ��������
    public void ClickjellyBuy()
    {
        isJellyBuy = !isJellyBuy;
        if (isJellyBuy)
        {
            jellyBuyChang.SetActive(true);
            store.SetActive(false);
        }
    }

    public void OutJellyBey()
    {
        isJellyBuy = !isJellyBuy;
        jellyBuyChang.SetActive(false);
        store.SetActive(true);
    }
    #endregion

    #region �����۱���
    public void ClickItemBuy()
    {
        isItemBuy = !isItemBuy;
        if(isItemBuy)
        {
            itemBuyChang.SetActive(true);
            store.SetActive(false);
        }
    }

    public void OutItemBuy()
    {
        isItemBuy = !isItemBuy;
        itemBuyChang.SetActive(false);
        store.SetActive(true);
    }
    #endregion

    // �ڽ� �θ� â�� ���� �ڵ�
    public void OutChang()
    {
        
    }
}
