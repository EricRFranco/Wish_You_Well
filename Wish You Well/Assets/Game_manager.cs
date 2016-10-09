using UnityEngine;
using System.Collections;

public class Game_manager : MonoBehaviour {

	// Use this for initialization
	int state;
	void Start () {
		state = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void StartGame()
	{
		state = 1;

	}
	void GameOver()
	{
		print("Wish unfulfilled");
	}
}
