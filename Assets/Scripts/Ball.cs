using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
	private Paddle paddle;
	private bool ballLaunched;
	private Vector3 paddleToBallVector;

	private void launchBall(){
		this.GetComponent<Rigidbody2D>().velocity = new Vector2 (2f, 10f);
		ballLaunched = true;
	}

	private void stickBallToPaddle(){
		// Keeps ball relative to the paddle by vector.
		this.transform.position = paddle.transform.position + paddleToBallVector;
	}

	// Use this for initialization
	void Start () {
		paddle = GameObject.FindObjectOfType<Paddle>();
		paddleToBallVector = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if(!ballLaunched){
			stickBallToPaddle();
			if (Input.GetMouseButton(0)){
				launchBall(); //ball_launched is true
			}
		}
	}
}
