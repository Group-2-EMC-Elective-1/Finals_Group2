using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }
    public void LoadEasyGame(string name)
    {
        GameSettings.instance.SetGameMode(GameSettings.EGameMode.EASY);
        SceneManager.LoadScene(name);
    }
    public void LoadMediumGame(string name)
    {
        GameSettings.instance.SetGameMode(GameSettings.EGameMode.MEDIUM);
        SceneManager.LoadScene(name);
    }
    public void LoadHardGame(string name)
    {
        GameSettings.instance.SetGameMode(GameSettings.EGameMode.HARD);
        SceneManager.LoadScene(name);
    }

    public void ActivateObj(GameObject obj)
    {
        obj.SetActive(true);
    }
    public void DeativateObj(GameObject obj)
    {
        obj.SetActive(false);
    }

    public void ContinuePreviousGame(bool continue_game)
    {
        GameSettings.instance.SetContinuePreviousGame(continue_game);
    }
}
