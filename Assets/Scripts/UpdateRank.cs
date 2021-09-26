using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateRank : MonoBehaviour
{
    [SerializeField] private Text rankNameText = null;
    [SerializeField] private Text rankPriceText = null;
    [SerializeField] private Text rankAmountText = null;
    [SerializeField] private Button purChaseButton = null;
    [SerializeField] private Image rankImage = null;
    [SerializeField] private Sprite[] rankSprite;

    public void OnClcikPurChase()
    {
        int i = 0;
        i++;
        rankImage.sprite = rankSprite[i];
    }
}


