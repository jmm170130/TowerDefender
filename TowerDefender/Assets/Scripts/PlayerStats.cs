using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static int Money;
    public int startMoney;

    public static int LivesLeft;
    public int Lives = 1;

    void Start()
    {
        Money = startMoney;
        LivesLeft = Lives;
    }
}
