using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool gameEnded = false;
    public GameObject gameOverUI;

    // Update is called once per frame
    public void Update()
    {
        if(gameEnded)
        {
            return;
        }

        /*
        if(PlayerStats.Lives <= 0)
        {
            EndGame();
        }
        */
    }

    public void EndGame()
    {
        gameEnded = true;
        gameOverUI.SetActive(true);  
    }
}
