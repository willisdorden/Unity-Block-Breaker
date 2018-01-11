using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

	// Use this for initialization

	public int maxHits;
	private int timesHit;
	private LoadManager loadManager;
    public Sprite[] hitSprites;
	void Start ()
	{
		timesHit = 0;
		loadManager = GameObject.FindObjectOfType<LoadManager>();

	}
	
	// Update is called once per frame
	void Update () {
		
	
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		timesHit++;
		
		if (timesHit >= maxHits){
			Destroy(gameObject);
		}else{
			LoadSprites();
		}
	}

	void LoadSprites(){
		int spriteIndex = timesHit - 1;
		this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
	}
	
	// Todo remove this method once we can actually win

	void SimulateWin(){
		loadManager.LoadNextLevel();
	}

}



