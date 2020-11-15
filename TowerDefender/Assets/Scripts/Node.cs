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

    void Start()
    {
        render = GetComponent<Renderer>();
        startColor = render.material.color;
        buildManager = BuildManager.instance;
    }

    private GameObject weapon;
    void OnMouseDown()
    {
        if(EventSystem.current.IsPointerOverGameObject())
		{
			return;
		}

		if(buildManager.GetItemToBuild() == null)
		{
			return;
		}

        if(weapon != null)
        {
            return;
        }

        //Build the weapon
        GameObject itemToBuild = buildManager.GetItemToBuild();
        weapon = (GameObject)Instantiate(itemToBuild, transform.position + offset, transform.rotation);
    }

    // Highligth the tile the mouse is hovering over
    void OnMouseEnter()
    {
        if(EventSystem.current.IsPointerOverGameObject())
		{
			return;
		}

		if(buildManager.GetItemToBuild() == null)
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
