using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class GridSquare : Selectable, IPointerClickHandler, ISubmitHandler,IPointerUpHandler, IPointerExitHandler
{
    public GameObject numberTxt;
    private int number_ = 0;
    private bool selected = false;
    private int squareIndex_ = -1;

    public bool isSelected()
    {
        return selected;
    }

    public void SetSquareIndex(int index)
    {
        squareIndex_ = index;
    }

    void Start()
    {
        selected = false;
    }

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
    
    public void OnPointerClick(PointerEventData eventData)//click?
    {
        selected = true;
        GameEvent.squareSelectedMethod(squareIndex_);
    }

    public void OnSubmit(BaseEventData eventData)
    {
        
    }

    private void OnEnable()
    {
        GameEvent.OnUpdateSquareNumber += OnSetNumber;
        GameEvent.OnSquareSelected += OnSquareSelected;
    }

    private void OnDisable()
    {
        GameEvent.OnUpdateSquareNumber -= OnSetNumber;
        GameEvent.OnSquareSelected -= OnSquareSelected;
    }

    public void OnSetNumber(int number)
    {
        if (selected)
        {
            SetNumber(number);
        }
    }

    public void OnSquareSelected(int squareIndex)
    {
        if (squareIndex_ != squareIndex)//when clicking other square
        {
            selected = false;
        }
    }
}
