﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static int Money;
    public int startMoney;

    void Start()
    {
        Money = startMoney;
        Debug.Log("Starting Balance: " + startMoney);
    }
}
