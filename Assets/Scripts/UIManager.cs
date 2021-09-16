using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text fireText = null;
    [SerializeField] private GameObject upgradePannelTemplate = null;

    private List<UpgradePannel> upgradePannel = new List<UpgradePannel>();
    private void Start()
    {
        UpdateJellyPanel();
        CreatePannels();
    }

    private void CreatePannels()
    {
        GameObject newPannel = null;
        UpgradePannel newPannelComponent = null;

        foreach(Jelly jelly in GameManager.Instance.CurrentUser.jellyList)
        {
            newPannel = Instantiate(upgradePannelTemplate, upgradePannelTemplate.transform.parent);
            newPannelComponent = newPannel.GetComponent<UpgradePannel>();
            newPannelComponent.SetValue(jelly);
            newPannel.SetActive(true);
            upgradePannel.Add(newPannelComponent);
        }

    }
    public void OnClickJelly()
    {
        GameManager.Instance.CurrentUser.jellyPiece += GameManager.Instance.CurrentUser.jellyPerClick;
        UpdateJellyPanel();
        //Debug.Log("클릭함");
    }

    public void UpdateJellyPanel()
    {
        fireText.text = $" {GameManager.Instance.CurrentUser.jellyPiece} 젤리조각 \n";
    }


}
