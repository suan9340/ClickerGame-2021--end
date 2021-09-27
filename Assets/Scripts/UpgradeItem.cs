using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeItem : MonoBehaviour
{
    [SerializeField] private Text itemNameText = null;
    [SerializeField] private Text itemPriceText = null;
    [SerializeField] private Text itemAmountText = null;
    [SerializeField] private Button purChaseButton = null;
    [SerializeField] private Image itemImage = null;
    [SerializeField] private Sprite[] jellySprite;
    private long curnet;

    private Item item = null;

    public void SetValue(Item _item)
    {
        this.item = _item;
        UpdateUI();
    }

    public void UpdateUI()
    {
        itemNameText.text = item.itemName;
        itemPriceText.text = $"{item.price}개";
        itemAmountText.text = $"{item.amount}";
        itemImage.sprite = jellySprite[item.itemNumber];
        InvokeRepeating("A", 0f, 1f);
    }
    public void OnClickPurChase()
    {
        if (GameManager.Instance.CurrentUser.jellyPiece < item.price)
        {
            return;
        }
        if(item.itemNumber==0)
        {
            curnet= GameManager.Instance.CurrentUser.jellyPerAuto * 10 / 100;
            GameManager.Instance.CurrentUser.jellyPerAuto += curnet;
            Debug.Log("브림 구매");
        }
        else if(item.itemNumber==1)
        {
            GameManager.Instance.UI.OnClickJelly();
            Debug.Log("킬조이 구매");
        }
        GameManager.Instance.CurrentUser.jellyPiece -= item.price;
        //GameManager.Instance.CurrentUser.jellyPerAuto += item.jellyPerSecond;
        item.price = (long)(item.price * 1.25f);
        item.amount++;
        UpdateUI();
        GameManager.Instance.UI.UpdateJellyPanel();
        A();
    }

    private void A()
    {
        purChaseButton.interactable = item.price < GameManager.Instance.CurrentUser.jellyPiece;
    }
}
