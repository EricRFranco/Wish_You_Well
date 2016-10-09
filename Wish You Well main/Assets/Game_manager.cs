using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Game_manager : MonoBehaviour {

	// Use this for initialization
	public int state;
	int coinsSaved;
	void Start () {
		state = 1;
		coinsSaved = 0;
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
		//print("Wish unfulfilled");
		SceneManager.LoadScene(2);
	}

	void SaveCoin()
	{
		coinsSaved++;
	}
}
