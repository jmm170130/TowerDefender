using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinLevel : MonoBehaviour
{
    public void toLv2()
    {
        SceneManager.LoadScene("Level 2");
    }

    public void toLv3()
    {
        SceneManager.LoadScene("Level 3");
    }

    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
