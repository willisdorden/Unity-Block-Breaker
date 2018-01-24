using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

	private Paddle paddle;

	private Vector3 paddleToBallVector;
	private bool hasStarted = false;
	public Rigidbody2D rb;
	void Start ()
	{
		paddle = GameObject.FindObjectOfType<Paddle>();
		paddleToBallVector = this.transform.position - paddle.transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!hasStarted)
		{
		this.transform.position = paddle.transform.position + paddleToBallVector;

			if (Input.GetMouseButtonDown(0))
			{
				print("Launch ball");
				hasStarted = true;
				this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);

			}
		}
	}
	void OnCollisionEnter2D(Collision2D collision)
	{
		Vector2 tweak = new Vector2(Random.Range(0f, .2f), Random.Range(0f, .2f));
		
		if (hasStarted)
		{
			AudioSource audio = GetComponent<AudioSource>();
			audio.Play();
			rb = GetComponent<Rigidbody2D>();
			rb.velocity += tweak;
		}
	}

	
	
}
