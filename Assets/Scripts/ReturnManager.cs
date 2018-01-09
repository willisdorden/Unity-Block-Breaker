using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnManager : MonoBehaviour {

	public void LoadLevel(string name)
	{
		Debug.Log("Level load for " + name);
		Application.LoadLevel(name);
	}
}
