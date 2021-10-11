using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour

{

    [SerializeField] Image musicaOn;
    [SerializeField] Image musicaOff;

    private bool mute = false;
    
    void Start()
    {
        
    }

    public void OnButtonPress()
{
    if(mute == false)
    {
        mute = true;
        AudioListener.pause = true;
    }

    else
    {
        mute = false;
        AudioListener.pause = false;
    }

    UpdateButtonIcon();
    AudioListener.pause = mute;
}

    private void UpdateButtonIcon()
    {
        if(mute == false)
        {
            musicaOff.enabled = false;
            musicaOn.enabled = true;
        }

        else
        {
            musicaOff.enabled = true;
            musicaOn.enabled = false;
        }
    }

}