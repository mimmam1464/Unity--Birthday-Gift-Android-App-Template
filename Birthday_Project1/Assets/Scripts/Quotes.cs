using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quotes : MonoBehaviour
{
    public Text textBox;
    public string[] quotes;
    private int currentQuote = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextButton()
    {
        currentQuote++;
        if (currentQuote >= quotes.Length)
            currentQuote = 1;
        else if (currentQuote > DateTime.Now.Hour)
            currentQuote = 0;
        textBox.text = quotes[currentQuote];
    }
    
    public void PrevButton()
    {
        currentQuote--;
        if (currentQuote < 1)
            currentQuote = quotes.Length-1;
        textBox.text = quotes[currentQuote];
    }
}
