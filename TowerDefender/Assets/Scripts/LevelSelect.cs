using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{

    public void SelectLv1()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void SelectLv2()
    {
        SceneManager.LoadScene("Level 2");
    }

    public void SelectLv3()
    {
        SceneManager.LoadScene("Level 3");
    }

    public void SelectLv4()
    {
        //SceneManager.LoadScene("Level 4");
    }

    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
