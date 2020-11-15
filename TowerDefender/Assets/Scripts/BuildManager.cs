using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;
  
    // Maintain a single BuildManager instance
    void Awake()
    {
        instance = this;
    }
   
    public GameObject GetItemToBuild()
    {
        return itemToBuild;
    }

    public GameObject turretPrefab;
    public GameObject laserPrefab;
    public GameObject missileLauncherPrefab;

    private GameObject itemToBuild;
    public void SetItemToBuild( GameObject item)
    {
        itemToBuild = item;
    }
}