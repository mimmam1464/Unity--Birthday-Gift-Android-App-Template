using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class videoPlayer : MonoBehaviour
{
    public GameObject outputSourceRawImage;
    private RawImage outputSourceRawImageText;
    private VideoPlayer player;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        
        player = GetComponent<VideoPlayer>();
        player.Prepare();
        outputSourceRawImageText=outputSourceRawImage.GetComponent<RawImage>();
        outputSourceRawImageText.texture = null;
    }

    private void Update()
    {

        if (!player.isPlaying)
        {
            outputSourceRawImageText.texture=null;
            outputSourceRawImage.SetActive(false);
            //audioSource.Play();
        }
    }

    // Update is called once per frame
    public void PlayVideo()
    {
            
            outputSourceRawImage.SetActive(true);
            outputSourceRawImageText.texture = player.texture;
            audioSource.Pause();
            player.Play();

    }
}
