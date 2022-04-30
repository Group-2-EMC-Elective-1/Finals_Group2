using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSettings : MonoBehaviour
{
    public enum EGameMode
    {
        NOT_SET,
        EASY,
        MEDIUM,
        HARD
    }

    public static GameSettings instance;

    private void Awake()
    {
        if (instance == null)
        {
            DontDestroyOnLoad(this);
            instance = this;
        }
        else
            Destroy(this);
    }

    private EGameMode gameMode;
    private bool _ContinuePreviousGame = false;
    private bool _exitAfterWon = false;

    public void SetExitAfterWon(bool set)
    {
        _exitAfterWon = set;
        _ContinuePreviousGame = false;
    }

    public bool GetExitAfterWon()
    {
        return _exitAfterWon;
    }

    public void SetContinuePreviousGame(bool continue_game)
    {
        _ContinuePreviousGame = continue_game;
    }

    public bool GetContinuePreviousGame()
    {
        return _ContinuePreviousGame;
        _ContinuePreviousGame = false;
    }


    private void Start()
    {
        gameMode = EGameMode.NOT_SET;
    }

    public void SetGameMode (EGameMode mode)
    {
        gameMode = mode;
    }

    public void SetGameMode(string mode){
        if (mode == "Easy")
        {
            SetGameMode(EGameMode.EASY);
        }
        else if (mode == "Medium")
        {
            SetGameMode(EGameMode.MEDIUM);
        }
        else if (mode == "Hard")
        {
            SetGameMode(EGameMode.HARD);
        }
        else SetGameMode(EGameMode.NOT_SET);
    }

    public string GetGameMode()
    {
        switch (gameMode)
        {
            case EGameMode.EASY:return "Easy";
            case EGameMode.MEDIUM: return "Medium";
            case EGameMode.HARD: return "Hard";
        }

        Debug.LogError("Error: Game Level is not set!");
        return "";
    }
}
