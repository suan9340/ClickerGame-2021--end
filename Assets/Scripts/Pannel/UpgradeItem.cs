using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeItem : MonoBehaviour
{
    [SerializeField] private Text itemNameText = null;
    [SerializeField] private Text itemPriceText = null;
    [SerializeField] private Text itemAmountText = null;
    [SerializeField] private Text itemPerClick = null;
    [SerializeField] private Button purChaseButton = null;
    [SerializeField] private Image itemImage = null;
    [SerializeField] private Sprite[] tearSprite;

    private int index = 0;

    private Image image = null;

    private Item item = null;

    private void Start()
    {
        image = GetComponent<Image>();
        Check();
    }

    private void Update()
    {
        CheakCanBuy();
    }

    public void SetValue(Item _item)
    {
        item = _item;
        UpdateUI();
    }

    public void UpdateUI()
    {
        itemNameText.text = item.itemName;
        itemPriceText.text = $"{item.price}개";
        itemAmountText.text = $"{item.amount}Lv";
        itemPerClick.text = $"(+{item.perClick})/Click";
    }
    public void OnClickPurChase()
    {

        if (GameManager.Instance.CurrentUser.jellyPiece < item.price)
        {
            return;
        }
        CheakCanBuy();
        GameManager.Instance.CurrentUser.jellyPiece -= item.price;
        GameManager.Instance.CurrentUser.jellyPerClick += item.perClick;
        item.price = (long)(item.price * 1.8f);
        item.amount++;
        UpdateUI();
        PurChase();
        GameManager.Instance.UI.UpdateJellyPanel();
        SoundManager.Instance.PurChaseSound();

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
    public void PurChase()
    {
        if (item.amount > 19) return;
        index++;
        //Debug.Log(index); // 1부터 아이언 2
        itemImage.sprite = tearSprite[index];

    }

    private void Check()
    {
        index = item.amount;
        if (index > 19)
        {
            itemImage.sprite = tearSprite[19];
        }
        else
        {
            itemImage.sprite = tearSprite[index];
        }
    }

}
