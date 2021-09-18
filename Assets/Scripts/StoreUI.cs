using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreUI : MonoBehaviour
{
    [SerializeField] private GameObject store;
    //----------젤리구매 변수----------//
    [SerializeField] private GameObject jellyBuyChang;
    private bool isJellyBuy;

    //----------아이템구매 변수----------//
    [SerializeField] private GameObject itemBuyChang;
    private bool isItemBuy;

    #region 젤리구매
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

    #region 아이템구매
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

    // 자신 부모 창을 끄느 코드
    public void OutChang()
    {
        
    }
}
