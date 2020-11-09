using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager buildManager;
    public GameObject turretPrefab;
    private GameObject turretToBuild;

    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }

    void Awake()
    {
        buildManager = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        turretToBuild = turretPrefab;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
