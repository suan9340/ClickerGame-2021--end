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

    [Header("생성이미지")]
    [SerializeField] private GameObject jett;
    [SerializeField] private GameObject astra;
    [SerializeField] private GameObject sky;

    private Image image = null;

    private Jelly jelly = null;


    private void Start()
    {
        Check();
        image = GetComponent<Image>();
    }

    private void Update()
    {
        CheakCanBuy();
    }
    public void SetValue(Jelly _jelly)
    {
        jelly = _jelly;
        UpdateUI();
    }

    private void Check()
    {
        if(jelly.JellyNumber==0)
        {
            if(jelly.amount >= 1)
            {
                jett.SetActive(true);
            }
        }

        else if (jelly.JellyNumber==1)
        {
            if (jelly.amount >= 1)
            {
                astra.SetActive(true);
            }
        }

        else if(jelly.JellyNumber==2)
        {
            if (jelly.amount >= 1)
            {
                sky.SetActive(true);
            }
        }
    }
    public void UpdateUI()
    {
        jellyNameText.text = jelly.JellyName;
        jellyPriceText.text = $"{jelly.price}개";
        jellyAmountText.text = $"{jelly.amount}Lv";
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
        CheakCanBuy();

        if (jelly.JellyNumber == 0)
        {
            if(jelly.amount==1)
            {
                jett.SetActive(true);
            }
        }
        else if (jelly.JellyNumber == 1)
        {
            if(jelly.amount==1)
            {
                astra.SetActive(true);
            }

        }
        else if (jelly.JellyNumber == 2)
        {
            if(jelly.amount==1)
            {
                sky.SetActive(true);
            }

        }
    }
    private void CheakCanBuy()
    {
        if(jelly.price < GameManager.Instance.CurrentUser.jellyPiece)
        {
            purChaseButton.interactable = true;
            purChaseButton.image.color = new Color(0.4470588f, 1f, 0f, 1f);
            image.color = new Color(0.4470588f, 1f, 0f, 1f);

        }
        else
        {
            purChaseButton.interactable = false;
            purChaseButton.image.color = new Color(1f, 0f, 0f, 1f);
            image.color = new Color(1f, 0f, 0f, 1f);
        }
    }

}
