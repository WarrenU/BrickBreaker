using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void loadScene(string name){
		SceneManager.LoadScene(name);
	}

	private static void loadNextLevel(){
		SceneManager.LoadScene("Level_02");
	}

	public void BrickDestroyed(){
		if(Brick.breakableCount <= 0){
			loadNextLevel();
		}
	}

}
