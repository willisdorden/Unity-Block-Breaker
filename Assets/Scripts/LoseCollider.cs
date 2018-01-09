using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour
{

	private LoadManager loadManager;

	void OnCollisionEnter2D(Collision2D collision)
	{
		print("collision");
	}

	void OnTriggerEnter2D(Collider2D trigger)
	{

		loadManager = GameObject.FindObjectOfType<LoadManager>();
		loadManager.LoadLevel("Win");

	}
}
