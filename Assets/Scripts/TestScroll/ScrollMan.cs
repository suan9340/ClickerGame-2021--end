using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ScrollMan : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Scrollbar scrollerbar;
    public Transform contenTr;

    public Slider tabSlider;
    public RectTransform[] BtnRect;
    const int SIZE = 2;
    float[] pos = new float[SIZE];// 0, 0.496,0.999
    float distance,targetPos,curPos;
    bool isDrag;
    int targetIndex;
    private void Start()
    {
        distance = 1f / (SIZE - 1);
        for(int i=0;i<SIZE;i++)
        {
            pos[i] = distance * i;
        }
    }

    public void TabClick(int n)
    {
        targetIndex = n;
        targetPos = pos[n];
        SoundManager.Instance.ButtonClickSound();
    }

    private float SetPos()
    {
        for (int i = 0; i < SIZE; i++)
        {
            if (scrollerbar.value < pos[i] + distance * 0.5f && scrollerbar.value > pos[i] - distance * 0.5f)
            {
                targetIndex = i;
                return pos[i];
            }
        }

        return 0;
    }
    public void OnBeginDrag(PointerEventData eventData) => curPos = SetPos();

    public void OnDrag(PointerEventData eventData)
    {
        isDrag = true;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        isDrag = false;
        targetPos = SetPos();

        if(curPos==targetPos)
        {
            if(eventData.delta.x>18&&curPos-distance>=0)
            {
                --targetIndex;
                targetPos = curPos - distance;
            }

            else if(eventData.delta.x<-18&&curPos+distance<=1.0f)
            {
                ++targetIndex;
                targetPos = curPos + distance;
            }
        }
    }

    private void Update()
    {
        tabSlider.value = scrollerbar.value;

        if(!isDrag)
        {
            scrollerbar.value = Mathf.Lerp(scrollerbar.value, targetPos, 0.08f);
        }
    }

    
}
