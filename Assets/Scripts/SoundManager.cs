using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoSingleTon<SoundManager>
{
    [SerializeField] private AudioClip buttonClip;
    [SerializeField] private AudioClip purchaseClip;
    [SerializeField] private AudioClip clickClip;
    public void ButtonClickSound()
    {
        PlayEffectSound("buttonSound", buttonClip);
    }
    public void ClickCLick()
    {
        PlayEffectSound("click", clickClip);
    }
    public void PurChaseSound()
    {
        PlayEffectSound("puerchase", purchaseClip);
        
    }
    public void PlayEffectSound(string name, AudioClip clip)
    {
        GameObject go = new GameObject(name + "Sound");
        AudioSource audioSource = go.AddComponent<AudioSource>();
        audioSource.clip = clip;
        audioSource.Play();

        Destroy(go, clip.length);
    }

}
