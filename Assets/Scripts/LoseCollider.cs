using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {

	public LevelManager level_manager;

    void OnTriggerEnter2D(Collider2D trigger){
    	print("Trigger");
    	level_manager.load_level("Lose");
    }

	void OnCollisionEnter2D(Collision2D collision){
    	print("col");
    }
}
