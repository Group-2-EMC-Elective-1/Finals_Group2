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

    public delegate void WrongNumber();
    public static event WrongNumber OnWrongNumber;

    public static void OnWrongNumberMethod()
    {
        if (OnWrongNumber != null)
        {
            OnWrongNumber();
        }
    }
    public delegate void GameOver();
    public static event GameOver OnGameOver;

    public static void OnGameOverMethod()
    {
        if (OnGameOver != null)
        {
            OnGameOver();
        }
    }

}
