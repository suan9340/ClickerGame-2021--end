using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class JellyText : MonoBehaviour
{
    [SerializeField] private Canvas canvas = null;
    [SerializeField] private Transform pool = null;

    private Text jellyText = null;

    public void Show(Vector2 mousePosition)
    {
        jellyText = GetComponent<Text>();
        jellyText.text = $"+{GameManager.Instance.CurrentUser.jellyPerClick}";

        transform.SetParent(canvas.transform);
        transform.position = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = new Vector3(transform.position.x, transform.position.y, 0f);

        gameObject.SetActive(true);

        RectTransform rectTransform = GetComponent<RectTransform>();
        float targetPositionY = rectTransform.anchoredPosition.y + 50f;

        jellyText.DOFade(0f, 0.5f).OnComplete(() => Despawn());
        rectTransform.DOAnchorPosY(targetPositionY, 0.5f);
    }

    public void Despawn()
    {
        jellyText.DOFade(1f, 0f);
        transform.SetParent(pool);
        gameObject.SetActive(false);
    }
}
