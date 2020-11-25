using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool GameOver;
    public GameObject gameOverUI;

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
        Debug.Log("game Over");
        GameOver = true;
        gameOverUI.SetActive(true);  
    }
}
