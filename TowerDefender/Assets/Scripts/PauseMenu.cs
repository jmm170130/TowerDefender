using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
	public GameObject ui;

	public void Update()
	{
		// Show the pause menu when 'P' is pressed
		if( Input.GetKeyDown(KeyCode.P) )
		{
			Toggle();
		}
	}

	public void Toggle()
	{
		ui.SetActive( !ui.activeSelf );

		if( ui.activeSelf )
		{
			Time.timeScale = 0f;  // Freeze the game			
		}
		else
		{
			Time.timeScale = 1f; /// Unfreeze the game
		}
	}

	public void Retry()
	{
		Toggle();
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	public void Menu()
	{
		Debug.Log("Menu Method");
	}
}
