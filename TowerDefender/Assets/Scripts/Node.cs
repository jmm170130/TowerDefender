using System;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    public Vector3 offset;

    private GameObject turret;

    private Color startColor;
    private Renderer render;

    void Start()
    {
        render = GetComponent<Renderer>();
        startColor = render.material.color;
    }

    void OnMouseDown()
    {
        if(turret != null)
        {
            return;
        }

        //Build the turret
        GameObject turretToBuild = BuildManager.buildManager.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position + offset, transform.rotation);
    }

    void OnMouseEnter()
    {
        render.material.color = hoverColor;
    }

    void OnMouseExit()
    {
        render.material.color = startColor;
    }
}
