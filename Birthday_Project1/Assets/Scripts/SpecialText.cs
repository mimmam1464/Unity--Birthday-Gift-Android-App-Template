using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//THIS SCRIPT CHANGES THE TEXt AT THE TOP AFTER EVERY 4S//
public class SpecialText : MonoBehaviour
{
    private Text specialText;  //The special text attached to this gameobject
    private string[] storedTexts = new[] {"Your Special Sanjana", "A Special Annoying Idiot"};

    private float timer = 4f;
    private int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        specialText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            index++;
            if (index == 2)
                index = 0;
            specialText.text = storedTexts[index];
            timer = 4f;
        }
    }
}
