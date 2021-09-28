using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateChallenge : MonoBehaviour
{
    [SerializeField] private Text challengeInfo;
    [SerializeField] private Button CompleteBtn;
    [SerializeField] private Text challengeCompensation;

    private Challenge challenge;

    public void SetValues(Challenge _challenge)
    {
        challenge = _challenge;
        UpdateUI();
    }

    public void UpdateUI()
    {
        challengeInfo.text= $"{challenge.ChallengeName}";
        challengeCompensation.text=$"{challenge.Challengecompensation}°³";
    }
}
