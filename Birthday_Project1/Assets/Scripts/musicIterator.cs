using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class musicIterator : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audioSource;
    public AudioClips[] musics;
    public RawImage rawImage;
    public Text messageText;
    
    private int index = 0;

    public void Next()
    {
        index++;
        if (index >= musics.Length)
            index = 0;
        rawImage.texture = musics[index].texture;
        messageText.text = musics[index].msg;
        audioSource.clip = musics[index].audios;
        audioSource.Play();
    }

    public void Previous()
    {
        index--;
        if (index < 0)
            index = musics.Length - 1;
        rawImage.texture = musics[index].texture;
        messageText.text = musics[index].msg;
        audioSource.clip = musics[index].audios;
        audioSource.Play();
    }

}

[System.Serializable]
public struct AudioClips
{
    public AudioClip audios;
    public Texture texture;
    public string msg;
}

