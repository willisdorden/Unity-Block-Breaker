using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

	// Use this for initialization

	static  MusicPlayer instance  = null;

	void Awake()
	{
		Debug.Log("Music player Awake" + GetInstanceID());
		if (instance != null)
		{
			Destroy (gameObject);
			print("Music player is destroyed");
		} else
		{
			instance = this;
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}
	void Start ()
	{
		Debug.Log("Music player start" + GetInstanceID());

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
