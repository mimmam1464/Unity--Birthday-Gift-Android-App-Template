using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class passWord : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject passwordBox;
    public Text wrong;
    public string correctPassword;
    public int nextSceneNumber;

    private void Start()
    {
        passwordBox.SetActive(false);
        wrong.enabled = false;
    }

  
    public void ShowPasswordBox()
    {
        passwordBox.SetActive(true);
        TouchScreenKeyboard.Open("Hello");
    }

    public void closeShowBox()
    {
        passwordBox.SetActive(false);
    }

    public void passwordCheck(Text value)
    {
        if (value.text == correctPassword)
        {
            //Password Passed!
            SceneManager.LoadScene(nextSceneNumber);
        }

        else
        {
            //Password Not right. False
            wrong.enabled = true;
        }
    }
    
}
