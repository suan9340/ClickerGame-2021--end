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
    // 젤리 구매 눌렀을 때
    public void ClickjellyBuy()
    {
        isJellyBuy = !isJellyBuy;
        if (isJellyBuy)
        {
            jellyBuyChang.SetActive(true);
            store.SetActive(false);
        }
    }

    // 젤리 구매 나가기 눌렀을 때
    public void OutJellyBey()
    {
        Debug.Log("qwe");
        isJellyBuy = !isJellyBuy;
        jellyBuyChang.SetActive(false);
        store.SetActive(true);
    }
    #endregion

    #region 아이템구매
    // 아이템 구매 눌렀을 때
    public void ClickItemBuy()
    {
        isItemBuy = !isItemBuy;
        if(isItemBuy)
        {
            itemBuyChang.SetActive(true);
            store.SetActive(false);
        }
    }

    // 아이템 구매 나가기 눌렀을 때
    public void OutItemBuy()
    {
        isItemBuy = !isItemBuy;
        itemBuyChang.SetActive(false);
        store.SetActive(true);
    }
    #endregion
}
