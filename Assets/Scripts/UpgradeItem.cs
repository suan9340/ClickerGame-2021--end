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

    private Image image = null;


    private Item item = null;

    private void Start()
    {
        image = GetComponent<Image>();
    }

    private void Update()
    {
        CheakCanBuy();
    }

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
    }
    public void OnClickPurChase()
    {
        if (GameManager.Instance.CurrentUser.jellyPiece < item.price)
        {
            return;
        }
        if(item.itemNumber==0)
        {
            Debug.Log("브림 구매");
        }
        else if(item.itemNumber==1)
        {
            Debug.Log("킬조이 구매");
        }
        GameManager.Instance.CurrentUser.jellyPiece -= item.price;
        //GameManager.Instance.CurrentUser.jellyPerAuto += item.jellyPerSecond;
        item.price = (long)(item.price * 1.25f);
        item.amount++;
        UpdateUI();
        GameManager.Instance.UI.UpdateJellyPanel();
        CheakCanBuy();
    }

    private void CheakCanBuy()
    {
        if (item.price < GameManager.Instance.CurrentUser.jellyPiece)
        {
            purChaseButton.interactable = true;
            purChaseButton.image.color = new Color(1f, 0f, 0.3568628f, 1f);
            image.color = new Color(1f, 0f, 0.3568628f, 1f);

        }
        else
        {
            purChaseButton.interactable = false;
            purChaseButton.image.color = new Color(1f, 0f, 0f, 1f);
            image.color = new Color(1f, 0f, 0f, 1f);
        }
    }
}
