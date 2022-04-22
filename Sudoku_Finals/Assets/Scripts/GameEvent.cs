using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvent : MonoBehaviour
{
    public delegate void UpdateScoreNumber(int number);

    public static event UpdateScoreNumber OnUpdateSquareNumber;

    public static void UpdateSquareNumberMethod(int number)
    {
        if (OnUpdateSquareNumber != null)
        {
            OnUpdateSquareNumber(number);
        }
    }

    public delegate void squareSelected(int squareIndex);

    public static event squareSelected OnSquareSelected;

    public static void squareSelectedMethod(int squareIndex)
    {
        if (OnSquareSelected != null)
        {
            OnSquareSelected(squareIndex);
        }
    }

}
