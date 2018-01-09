using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadManager : MonoBehaviour {

	public void LoadLevel(string name)
	{

		Debug.Log("Level load for " + name);
		Application.LoadLevel(name);
	}

	public void QuitRequest()
	{
		Debug.Log("Quitting the game");
		Application.Quit();
	}

	public void LoadNextLevel()
	{
		Application.LoadLevel(Application.loadedLevel + 1);
	}
}
