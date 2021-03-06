using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text jellyText = null;

    [SerializeField] private GameObject upgradePannelTemplate = null;
    [SerializeField] private GameObject upgradeItemPannelTemplate = null;
    //[SerializeField] private GameObject upgradeChallengePannelTemplate = null;
    [SerializeField] private GameObject upgradeItemsPannelTemplate = null;

    [SerializeField] private Transform pool = null;
    [SerializeField] private JellyText jellyTextTemplate = null;

    [SerializeField] private Animator storeAnimator;
    [SerializeField] private Animator playerAnimator;

    private List<UpgradePannel> upgradePannel = new List<UpgradePannel>();
    private List<UpgradeItem> upgradeItemPannel = new List<UpgradeItem>();
    private List<UpdateChallenge> upgradeChallengePannel = new List<UpdateChallenge>();
    private List<UpgradeItemsPannel> upgradeItemsPannels = new List<UpgradeItemsPannel>();

    private void Start()
    {
        PannelsUpdate();
    }

    private void Update()
    {
        KeyInPut();
    }

    private void KeyInPut()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnClickJelly();
        }
    }
    private void PannelsUpdate()
    {
        UpdateJellyPanel();
        CreatePannels();
        CreateItem();
        CreateItems();
        //CreateChallenge();
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

    private void CreateItem()
    {
        GameObject newPannel = null;
        UpgradeItem newPannelComponent = null;

        foreach (Item item in GameManager.Instance.CurrentUser.itemList)
        {
            newPannel = Instantiate(upgradeItemPannelTemplate, upgradeItemPannelTemplate.transform.parent);
            newPannelComponent = newPannel.GetComponent<UpgradeItem>();
            newPannelComponent.SetValue(item);
            newPannel.SetActive(true);
            upgradeItemPannel.Add(newPannelComponent);
        }
    }

    //private void CreateChallenge()
    //{
    //    GameObject newPannel = null;
    //    UpdateChallenge newPannelComponent = null;
    //    foreach(Challenge challenge in GameManager.Instance.CurrentUser.challengeList)
    //    {
    //        newPannel = Instantiate(upgradeChallengePannelTemplate, upgradeChallengePannelTemplate.transform.parent);
    //        newPannelComponent = newPannel.GetComponent<UpdateChallenge>();
    //        newPannelComponent.SetValues(challenge);
    //        newPannel.SetActive(true);
    //        upgradeChallengePannel.Add(newPannelComponent);
    //    }
    //}

    private void CreateItems()
    {
        GameObject newPannel = null;
        UpgradeItemsPannel newPannelComponent = null;
        foreach(Items items in GameManager.Instance.CurrentUser.itemsList)
        {
            newPannel = Instantiate(upgradeItemsPannelTemplate, upgradeItemsPannelTemplate.transform.parent);
            newPannelComponent = newPannel.GetComponent<UpgradeItemsPannel>();
            newPannelComponent.SetValues(items);
            newPannel.SetActive(true);
            upgradeItemsPannels.Add(newPannelComponent);
        }
    }
    public void OnClickJelly()
    {
        storeAnimator.Play("Clickshake");
        playerAnimator.Play("ClickBig");
        SoundManager.Instance.ClickCLick();
        GameManager.Instance.CurrentUser.jellyPiece += GameManager.Instance.CurrentUser.jellyPerClick;
        UpdateJellyPanel();

        JellyText newText = null;
        if(pool.childCount>0)
        {
            newText = pool.GetChild(0).GetComponent<JellyText>();
        }
        else
        {
            newText = Instantiate(jellyTextTemplate, jellyTextTemplate.transform.parent);
        }

        newText.Show(Input.mousePosition);
    }

    public void UpdateJellyPanel()
    {
        jellyText.text = $"{GameManager.Instance.CurrentUser.jellyPiece}??";
        //jellyPerSecond.text = $"{GameManager.Instance.CurrentUser.jellyPerAuto}?? ???? ????\n";
    }


}
