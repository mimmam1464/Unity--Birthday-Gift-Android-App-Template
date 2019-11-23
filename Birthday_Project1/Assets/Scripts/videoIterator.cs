using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class videoIterator : MonoBehaviour
{
   public VideoClip[] videos;

   public AudioSource AudioSource => audioSource;

   private int index = -1;
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
      
      player.targetTexture = null;
      player.clip = videos [0];
      //Next();
   }

   private void Update()
   {

      if (!player.isPlaying)
      {
         //outputSourceRawImageText.texture=null;
         //outputSourceRawImage.SetActive(false);
         //audioSource.Play();
      }
   }

   // Update is called once per frame
   public void PlayVideo()
   {
      if (player.isPrepared)
      {   
         outputSourceRawImage.SetActive(true);
         outputSourceRawImageText.texture = player.texture;
         audioSource.Pause();
         player.Play();
      }
      
      print(videos[index]);

   }

  
   public void Next()
   {
      index++;
      if (index >= videos.Length)
         index = 0;
      player.targetTexture = null;
      player.clip = videos[index];
      
      PlayVideo();

   }

   public void Previous()
   {
      index--;
      if (index < 0)
         index = videos.Length-1;
      player.targetTexture = null;
      player.clip = videos[index];
      PlayVideo();
   }
}
