using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

	// Use this for initialization

	public int maxHits;
	private int timesHit;
	
	void Start ()
	{
		timesHit = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		timesHit++;
	}
}
