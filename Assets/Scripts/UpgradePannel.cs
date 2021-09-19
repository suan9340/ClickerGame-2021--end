using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradePannel : MonoBehaviour
{
    [SerializeField] private Text jellyNameText = null;
    [SerializeField] private Text jellyPriceText = null;
    [SerializeField] private Text jellyAmountText = null;
    [SerializeField] private Button purChaseButton = null;
    [SerializeField] private Image jellyImage = null;
    [SerializeField] private Sprite[] jellySprite;

    private Jelly jelly = null;

    public void SetValue(Jelly _jelly)
    {
        this.jelly = _jelly;
        UpdateUI();
    }

    public void UpdateUI()
    {
        jellyNameText.text = jelly.JellyName;
        jellyPriceText.text = $"{jelly.price} 젤리조각";
        jellyAmountText.text = $"{jelly.amount}";
        jellyImage.sprite = jellySprite[jelly.JellyNumber];
    }

    public void OnClickPurChase()
    {
        if (GameManager.Instance.CurrentUser.jellyPiece < jelly.price)
        {
            return;
        }
        GameManager.Instance.CurrentUser.jellyPiece -= jelly.price;
        GameManager.Instance.CurrentUser.jellyPerAuto += jelly.jellyPerSecond;
        jelly.price = (long)(jelly.price * 1.25f);
        jelly.amount++;
        UpdateUI();
        GameManager.Instance.UI.UpdateJellyPanel();
        //Debug.Log("아이템 구매 성공");
    }
}
