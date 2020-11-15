using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildManager buildManager;

    void Start()
    {
        // Get the singleton instance of buildManager
        buildManager = BuildManager.instance;
    }

    public void PurchaseTurret()
    {
        buildManager.SetItemToBuild(buildManager.turretPrefab);
    }

    public void PurchaseLaser()
    {
        buildManager.SetItemToBuild(buildManager.laserPrefab);
    }

    public void PurchaseMissileLauncher()
    {
        buildManager.SetItemToBuild(buildManager.missileLauncherPrefab);
    }
}