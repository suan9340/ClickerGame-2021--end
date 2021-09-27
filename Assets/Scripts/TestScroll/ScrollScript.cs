using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class ScrollScript : ScrollRect
{
    bool forParent;
    ScrollMan SM;
    ScrollRect parentScrollRect;

    protected override void Start()
    {
        SM = GameObject.FindWithTag("scrollMan").GetComponent<ScrollMan>();
        parentScrollRect = GameObject.FindWithTag("scrollMan").GetComponent<ScrollRect>();
    }


    public override void OnBeginDrag(PointerEventData eventData)
    {
        // �巡�� �����ϴ� ���� �����̵��� ũ�� �θ� �巡�� ������ ��, �����̵��� ũ�� �ڽ��� �巡�� ������ ��
        forParent = Mathf.Abs(eventData.delta.x) > Mathf.Abs(eventData.delta.y);

        if (forParent)
        {
            SM.OnBeginDrag(eventData);
            parentScrollRect.OnBeginDrag(eventData);
        }
        else base.OnBeginDrag(eventData);
    }

    public override void OnDrag(PointerEventData eventData)
    {
        if (forParent)
        {
            SM.OnDrag(eventData);
            parentScrollRect.OnDrag(eventData);
        }
        else base.OnDrag(eventData);
    }

    public override void OnEndDrag(PointerEventData eventData)
    {
        if (forParent)
        {
            SM.OnEndDrag(eventData);
            parentScrollRect.OnEndDrag(eventData);
        }
        else base.OnEndDrag(eventData);
    }

}