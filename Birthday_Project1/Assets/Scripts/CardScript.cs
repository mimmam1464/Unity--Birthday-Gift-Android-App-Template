using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardScript : MonoBehaviour
{
    public GameObject leftSide;
    public GameObject RightSide;
    public GameObject[] buttons= new GameObject[4];

    private bool open = false;
    private bool close1 = false;
    private bool turn = false;
    private bool closeturn = false;

    private void Start()
    {
        buttons[1].SetActive(false);
        buttons[2].SetActive(false);
        buttons[3].SetActive(false);
    }

    private void Update()
    {
        if (open & (leftSide.transform.rotation.y>-1 & leftSide.transform.rotation.y<0))
        {
            Rotate(-1, leftSide);
        }
        else if (open)
        {
            open = false;
            buttons[1].SetActive(true);
        }

        
        else if (close1 & (leftSide.transform.rotation.y<0.1 & leftSide.transform.rotation.y>-0.99))
        {
            Rotate(1, leftSide);
        }
        else if (close1)
        {
            close1 = false;
            buttons[0].SetActive(true);
        }
        
        else if (turn & (RightSide.transform.rotation.y>=-0.1& RightSide.transform.rotation.y<0.955))
        {
            Rotate(-1, RightSide);
        }
        else if (turn)
        {
            turn = false;
            buttons[2].SetActive(true);
        }
        
        else if (closeturn & RightSide.transform.rotation.y>0)
        {
            Rotate(1, RightSide);
        }
        else if (closeturn)
        {
            closeturn = false;
            buttons[3].SetActive(true);
        }

    }

    public void Rotate(int direction, GameObject side)
    {
        if (direction == -1)
        {
            side.transform.Rotate(0,3,0);
        }
        
        else if (direction == 1)
        {
            side.transform.Rotate(0,-3,0);
        }
    }

    public void openCard()
    {
        open = true;
        buttons[0].SetActive(false);
    }
    
    public void closeFirstPage()
    {
        close1 = true;
        buttons[3].SetActive(false);
       
    }

    public void turnCard()
    {
        turn = true;
        buttons[1].SetActive(false);
    }

    public void closeTurnPage()
    {
        closeturn = true;
        buttons[2].SetActive(false);
    }
}
