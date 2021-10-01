using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    //----------- 나가기 눌렀을 때 변수 -----------//
    [Header("나가기 눌렀을 때")]
    [SerializeField] private GameObject outGameChang;
    private bool isOutGame;

    [Header("초기화 눌렀을 떄")]
    [SerializeField] private GameObject ReturnGame;
    private bool isReturnGame;

    [SerializeField] private GameObject setHide;

    private void Update()
    {
        KeyInput();
    }

    private void KeyInput()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ClickOutGame();
        }
    }
    public void ClickOutGame()
    {
        isOutGame = !isOutGame;
        if(isOutGame)
        {
            setHide.SetActive(true);
            outGameChang.SetActive(true);
        }
        else
        {
            setHide.SetActive(false);
            outGameChang.SetActive(false);  
        }
    }

    public void ClickXChang()
    {
        isOutGame = !isOutGame;
        setHide.SetActive(false);
        outGameChang.SetActive(false);
    }

    public void ClickOut()
    {
        Debug.Log("게임종료성공");
        Application.Quit();
    }

    public void OnClickReTryGame()
    {
        isReturnGame = !isReturnGame;
        if(isReturnGame)
        {
            ReturnGame.SetActive(true);
            outGameChang.SetActive(true);
        }
        else
        {
            ReturnGame.SetActive(false);
            outGameChang.SetActive(false);
        }
    }

    public void ClickYesReTry()
    {
        GameManager.Instance.ResetEvery();
    }

    public void ClickNoReTry()
    {
        isReturnGame = !isReturnGame;
        ReturnGame.SetActive(false);
        outGameChang.SetActive(false);
    }
}
