using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Text levelsText;

    /*
    void onEnable()
    {
         levelsText.text = PlayerStats.Rounds.ToString();
    }
    */

    public void Retry()
    {
        SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex );
    }

    public void Menu()
    {
        Debug.Log("In Menu method");
    }
}
