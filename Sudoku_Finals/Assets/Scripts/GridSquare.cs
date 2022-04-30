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
    private int corret_number_ = 0;

    private bool selected = false;
    private int squareIndex_ = -1;
    private bool has_default_value_ = false;

    public void SetHasDefaultValue(bool has_default) { has_default_value_ = has_default; }
    private bool GetHasDefaultValue() { return has_default_value_; }


    public bool isSelected()
    {
        return selected;
    }

    public void SetSquareIndex(int index)
    {
        squareIndex_ = index;
    }

    public void SetCorrectNumber(int number)
    {
        corret_number_ = number;
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
        if (selected && has_default_value_ == false)
        {
            SetNumber(number);

            if (number_ != corret_number_)
            {
                var colors = this.colors;
                colors.normalColor = Color.red;
                this.colors = colors;

                GameEvent.OnWrongNumberMethod();
            }
            else
            {
                has_default_value_ = true;
                var colors = this.colors;
                colors.normalColor = Color.white;
                this.colors = colors;
            }
        }
    }

    public void OnSquareSelected(int squareIndex)
    {
        if (squareIndex_ != squareIndex)//when clicking other square
        {
            selected = false;
        }
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log(collision + "Is in my " + this.gameObject);
        selected = true;
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        selected = false;
    }
}
