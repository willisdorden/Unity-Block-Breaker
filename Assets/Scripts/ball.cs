using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{

	private Paddle paddle;

	private Vector3 paddleToBallVector;
	private bool hasStarted = false;
	
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
}
