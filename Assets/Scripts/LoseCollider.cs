using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {

	public LevelManager levelManager;

    void OnTriggerEnter2D(Collider2D trigger){
    	print("Trigger");
		levelManager.loadLevel("Lose");
    }

	void OnCollisionEnter2D(Collision2D collision){
    	print("col");
    }
}
