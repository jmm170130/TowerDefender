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
    public GameObject laserPrefab;
    public GameObject missileLauncherPrefab;

    private WeaponBlueprint itemToBuild;
 
    public bool canBuild { get { return itemToBuild != null; } }
  
    public WeaponBlueprint GetItemToBuild()
    {
        return itemToBuild;
    }

    public void SetItemToBuild(WeaponBlueprint item)
    {
        itemToBuild = item;
    }

    public void BuildWeaponOn(Node node)
    {
        if(PlayerStats.Money < itemToBuild.cost)
        {
            Debug.Log("Insufficient funds");
            return;
        }

        PlayerStats.Money -= itemToBuild.cost;

        GameObject weapon = (GameObject)Instantiate(itemToBuild.prefab, node.GetBuildPosition(), Quaternion.identity);
        node.weapon = weapon;
        Debug.Log("Remaining Balance: " + PlayerStats.Money);
    }
}