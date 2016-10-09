using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Start_Game : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown()
	{
		SceneManager.LoadScene(1);
	}
}
