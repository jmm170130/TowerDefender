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

    public GameObject turretPrefab;

    private GameObject turretToBuild;
    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }

    public void SetTurretToBuild( GameObject turret)
    {
        turretToBuild = turret;
    }
}
