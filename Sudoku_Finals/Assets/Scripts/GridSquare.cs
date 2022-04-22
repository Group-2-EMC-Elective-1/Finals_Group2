using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridSquare : Selectable
{
    public GameObject numberTxt;
    private int number_ = 0;

    public void DisplayText()
    {
        if(number_ <= 0)
        {
            numberTxt.GetComponent<Text>().text = " ";
        }
        else
            numberTxt.GetComponent<Text>().text = number_.ToString();
    }

    public void SetNumber(int number)
    {
        number_ = number;
        DisplayText();
    }
}
