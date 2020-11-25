using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static int Money;
    public int startMoney;

    public static int LivesLeft;

    void Start()
    {
        Money = startMoney;
        LivesLeft = 1;
    }
}
