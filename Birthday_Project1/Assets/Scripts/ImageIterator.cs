using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageIterator : MonoBehaviour
{

    public ImagesClass[] images;
    private int index = 0;
    public Image imageHolder;
    public Text textBox;


    public void Next()
    {
        index++;
        if (index >= images.Length)
            index = 0;
        imageHolder.sprite = images[index].img;
        if (textBox & images[index].msg!=null)
            textBox.text = images[index].msg;
    }

    public void Previous()
    {
        index--;
        if (index < 0)
            index = images.Length-1;
        imageHolder.sprite = images[index].img;
        if (textBox & images[index].msg!=null)
            textBox.text = images[index].msg;
    }

}

[System.Serializable]
public struct ImagesClass
{
    public Sprite img;
    public string msg;
}
