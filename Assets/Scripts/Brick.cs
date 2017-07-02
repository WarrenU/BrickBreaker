using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {
	public Sprite[] hitSprites;
	public static int breakableCount = 0;

	private bool brickIsBreakable;
	private int timesHit;

	// Use this for initialization
	void Start () {
		brickIsBreakable = (this.tag == "Breakable");
		timesHit = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D collision){
		if(brickIsBreakable){
			HandleHits();
			breakableCount += 1;
		}
	}

	void HandleHits(){
		int maxHits = hitSprites.Length + 1;
		timesHit += 1;
		if (timesHit >= maxHits){
			breakableCount -= 1;
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
