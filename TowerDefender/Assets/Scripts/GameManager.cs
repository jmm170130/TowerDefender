using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool GameOver;
    public static bool LevelClear = false;
    public GameObject gameOverUI;
    public GameObject completeLevelUI;

    void Start()
    {
        GameOver = false;
    }
    // Update is called once per frame
    public void Update()
    {
        if(GameOver)
        {
            return;
        }

        if(PlayerStats.LivesLeft <= 0)
        {
            EndGame();
        }
    }

    public void EndGame()
    {
        GameOver = true;
        gameOverUI.SetActive(true);  
    }

    public void WinLevel()
    {
        GameOver = true;
        completeLevelUI.SetActive(true);
    }
}
