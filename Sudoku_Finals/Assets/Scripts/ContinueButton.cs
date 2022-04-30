using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ContinueButton : MonoBehaviour
{
    public Text levelText;

    // Start is called before the first frame update
    void Start()
    {
        if (Config.GameDataFileExist() == false)
        {
            gameObject.GetComponent<Button>().interactable = false;
            levelText.text = " ";
            Debug.Log("NO FILE MAN");
        }
        else
        {
            Debug.Log("HAVE FILE GIRL");
            levelText.text = Config.ReadBoardLevel();
        }
    }

    public void SetGameData()
    {
        GameSettings.instance.SetGameMode(Config.ReadBoardLevel());
    }

}
