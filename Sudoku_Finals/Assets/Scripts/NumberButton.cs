using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
public class NumberButton : Selectable, IPointerClickHandler, ISubmitHandler,IPointerUpHandler, IPointerExitHandler
{
    public int value = 0;
    //public Rigidbody2D rb;

    /*void Start()
    {
       // rb = GetComponent<Rigidbody2D>();
       // rb.isKinematic = true;
       // rb.detectCollisions = true;
    }*/

    public void OnPointerClick(PointerEventData eventData)
    {
        GameEvent.UpdateSquareNumberMethod(value);
    }

    public void OnSubmit(BaseEventData eventData)
    {

    }
    private void OnMouseUp()
    {
        GameEvent.UpdateSquareNumberMethod(value);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject s = other.gameObject;
        Debug.Log("Connected to: " + s);
        //find square's script for is selected, then apply number in onmouseup
        //s.GetComponent<GridSquare>().isSelected();
    //should enable highlighting on collision
    }


}