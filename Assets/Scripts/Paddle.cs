using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 paddlePosition = new Vector3(0f, this.transform.position.y, 0f);
		print(this.transform.position.y);
		float mousePosition = (Input.mousePosition.x/Screen.width)*16;
		paddlePosition.x = Mathf.Clamp(mousePosition, -6f, 6f);
		this.transform.position = paddlePosition;
	}
}
