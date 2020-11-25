using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MoneyCounter : MonoBehaviour
{
    public Text moneyCount;
    // Update is called once per frame
    void Update()
    {
        moneyCount.text = "$" + PlayerStats.Money.ToString();
    }
}
