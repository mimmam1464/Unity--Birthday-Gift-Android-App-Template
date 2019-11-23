using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlideShowImage : MonoBehaviour
{

    public Sprite[] images;
    private float timer = 4f;
    private int index = 0;
    private Image imageHolder;

    private void Start()
    {
        imageHolder = GetComponent<Image>();
    }

    // Start is called before the first frame update
    void CakeVideo()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            timer = 4f;
            index++;
            if (index >= images.Length)
                index = 0;
            else if (index < 0)
                index = images.Length - 1;
            print(index);
            imageHolder.sprite = images[index];
        }
    }
    
}
