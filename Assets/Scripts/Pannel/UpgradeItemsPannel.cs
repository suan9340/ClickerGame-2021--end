using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeItemsPannel : MonoBehaviour
{
    [SerializeField] private Text itemsNameText = null;
    [SerializeField] private Text itemsPriceText = null;
    [SerializeField] private Text itemsAmountText = null;
    [SerializeField] private Button purChaseButton = null;

    private bool isClick;
    private Image image;
    private Items items;

    private void Start()
    {
        image = GetComponent<Image>();
    }

    private void Update()
    {
        CheakCanBuy();
    }
    public void SetValues(Items _items)
    {
        items = _items;
        UpdateUI();
    }

    public void UpdateUI()
    {
        itemsNameText.text = items.ItemsName;
        itemsPriceText.text = $"{items.price}°³";
        itemsAmountText.text = $"{items.amount}Lv";
    }

    public void OnClickPurchase()
    {
        if (GameManager.Instance.CurrentUser.jellyPiece < items.price)
        {
            return;
        }

        SoundManager.Instance.ClickItemPurchase();
        if(items.ItemsNumber==0)
        {
            StartCoroutine(ClickMore());
        }
        else if(items.ItemsNumber==1)
        {
            StartCoroutine(AutoClick());
        }
        CheakCanBuy();
        GameManager.Instance.CurrentUser.jellyPiece -= items.price;

        items.amount++;
        items.price = (long)(items.price * 1.3f);
        UpdateUI();
        GameManager.Instance.UI.UpdateJellyPanel();
    }

    private IEnumerator ClickMore()
    {
        long a = 0;
        a = GameManager.Instance.CurrentUser.jellyPerClick;
        GameManager.Instance.CurrentUser.jellyPerClick *= 2;
        yield return new WaitForSeconds(10f);
        GameManager.Instance.CurrentUser.jellyPerClick = a;
    }

    private IEnumerator AutoClick()
    {
        isClick = true;
        int i = 0;
        while(isClick)
        {
            GameManager.Instance.UI.OnClickJelly();
            i++;
            Debug.Log(i);
            if (i >= 100) isClick=false;
            yield return new WaitForSeconds(0.1f);
        }
    }
    private void CheakCanBuy()
    {
        if (items.price < GameManager.Instance.CurrentUser.jellyPiece)
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
