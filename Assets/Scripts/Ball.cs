using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
	public Paddle paddle;
	private bool ball_launched;
	private Vector3 paddle_to_ball_vect;

	private void launch_ball(){
		this.GetComponent<Rigidbody2D>().velocity = new Vector2 (2f, 10f);
		ball_launched = true;
	}

	private void stick_ball_to_paddle(){
		// Keeps ball relative to the paddle by vector.
		this.transform.position = paddle.transform.position + paddle_to_ball_vect;
	}

	// Use this for initialization
	void Start () {
		paddle_to_ball_vect = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if(!ball_launched){
			stick_ball_to_paddle();
			if (Input.GetMouseButton(0)){
				launch_ball(); //ball_launched is true
			}
		}
	}
}
