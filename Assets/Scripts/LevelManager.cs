using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	public void load_level(string level_name){
		Application.LoadLevel(level_name);
	}
	
	public void quit(){
		Application.Quit();
	}
}
