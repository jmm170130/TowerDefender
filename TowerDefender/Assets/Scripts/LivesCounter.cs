using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class LivesCounter : MonoBehaviour
{
    public Text lives;

    // Update is called once per frame
    void Update()
    {
        lives.text = "LIVES: " + PlayerStats.LivesLeft.ToString();
    }
}
