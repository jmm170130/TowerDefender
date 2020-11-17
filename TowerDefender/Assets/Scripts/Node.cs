using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class Node : MonoBehaviour
{
    public Vector3 offset;

    private Color startColor;
    public Color hoverColor;

    private Renderer render;
    BuildManager buildManager;

    [Header("Optional")]
    public GameObject weapon;

    private WeaponBlueprint weaponBlueprint;

    void Start()
    {
        render = GetComponent<Renderer>();
        startColor = render.material.color;
        buildManager = BuildManager.instance;
    }

    public Vector3 GetBuildPosition()
    {
        return transform.position + offset;
    }


    void OnMouseDown()
    {
        if(EventSystem.current.IsPointerOverGameObject())
		{
			return;
		}

		if(!buildManager.canBuild)
		{
			return;
		}

        if(weapon != null)
        {
            return;
        }

        //Build the weapon
        buildManager.BuildWeaponOn(this);
    }

    // Highligth the tile the mouse is hovering over
    void OnMouseEnter()
    {
        if(EventSystem.current.IsPointerOverGameObject())
		{
			return;
		}

		if(!buildManager.canBuild)
		{
			return;
		}
        render.material.color = hoverColor;
    }

    void OnMouseExit()
    {
        render.material.color = startColor;
    }
}
