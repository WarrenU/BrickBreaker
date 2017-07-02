using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {
	public Sprite[] hitSprites;

	private int timesHit;

	// Use this for initialization
	void Start () {
		timesHit = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D collision){
		if(this.tag == "Breakable"){
			HandleHits();
		}
	}

	void HandleHits(){
		int maxHits = hitSprites.Length + 1;
		timesHit += 1;
		if (timesHit >= maxHits){
			Destroy(gameObject);
		}
		else{
			LoadSprites();
		}
	}

	void LoadSprites(){
		int spriteIndex = timesHit - 1; // For 0 based index
		if(hitSprites[spriteIndex]){
			// if statement in place to make sure it doesn't set our sprite to None
			this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
		}
	}

}
