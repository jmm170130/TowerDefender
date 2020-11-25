using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{

    public WeaponBlueprint turret;
    public WeaponBlueprint laser;
    public WeaponBlueprint missileLauncher;

    BuildManager buildManager;

    void Start()
    {
        // Get the singleton instance of buildManager
        buildManager = BuildManager.instance;
    }

    public void PurchaseTurret()
    {
        buildManager.SetItemToBuild(turret);
    }

    public void PurchaseLaser()
    {
        buildManager.SetItemToBuild(laser);
    }

    public void PurchaseMissileLauncher()
    {
        buildManager.SetItemToBuild(missileLauncher);
    }
}