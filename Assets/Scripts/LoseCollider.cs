﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D trigger){
    	print("Trigger");
		SceneManager.LoadScene("Lose");
    }

	void OnCollisionEnter2D(Collision2D collision){
    	print("col");
    }
}
