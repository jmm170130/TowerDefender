using UnityEngine;
using UnityEngine.EventSystems;

public class Node : MonoBehaviour
{
	public Color hoverColor;
	private Renderer rend;
	private Color defaultColor;
	private GameObject turret;
	BuildManager buildManager;
	void Start()
	{
		// Get the initial color of the nodes
		rend = GetComponent<Renderer>();
		defaultColor = rend.material.color;

		buildManager = BuildManager.instance;
	}

	// Change the color of the nodes to the hoverColor
	void OnMouseEnter()
	{
		if(EventSystem.current.IsPointerOverGameObject())
		{
			return;
		}
		if(buildManager.GetTurretToBuild() == null)
		{
			return;
		}
		rend.material.color = hoverColor;
	}

	// Change the color of the nodes to the defaultColor
	void OnMouseExit()
	{
		rend.material.color = defaultColor;
	}

	// Add a new turret to the board
	void OnMouseDown()
	{
		if(EventSystem.current.IsPointerOverGameObject())
		{
			return;
		}

		// Only add a new turret to the map when one is selected from the shop
		if(buildManager.GetTurretToBuild() == null)
		{
			return;
		}

		if(turret != null)
		{
			Debug.Log("Can't Build Here!");
			return;
		}

		GameObject turretToBuild = buildManager.GetTurretToBuild();
		turret = (GameObject)Instantiate(turretToBuild, transform.position, transform.rotation);


	}

}
