using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
public class NumberButton : Selectable, IPointerClickHandler, ISubmitHandler,IPointerUpHandler, IPointerExitHandler
{
    public int value = 0;
    
    public void OnPointerClick(PointerEventData eventData)
    {
        GameEvent.UpdateSquareNumberMethod(value);
    }

    public void OnSubmit(BaseEventData eventData)
    {

    }
    private void OnMouseUpAsButton()
    {
        GameEvent.UpdateSquareNumberMethod(value);
    }

    /*private void OnCollisionEnter2D(Collision2D square)
    {
        //GameObject s = square.gameObject;
        //find square's script for is selected, then apply number in onmouseup
        //s.GetComponent<GridSquare>().isSelected();
    should enable highlighting on collision
    }*/


}

