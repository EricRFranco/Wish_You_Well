using UnityEngine;
using System.Collections;

public class Follow_camera : MonoBehaviour {

	// Use this for initialization
	int state;
	public GameObject player;
	public float xBound;
	//public float yBound;
	public float easing = 0.02f;
	void Start () {
		state = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if(state == 0)//Opening animation
		{
			//This will involve lerping
		}
		if(state == 1)//During gameplay
		{
			if(player.transform.position.x - transform.position.x > xBound)
			{
				//transform.position = new Vector3(transform.position.x + player.GetComponent<Rigidbody2D>().velocity.x, transform.position.y, transform.position.z);
				Vector3 destination= new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);
				destination = Vector3.Lerp(transform.position, destination, easing);
				transform.position = destination;
			}

			if(player.transform.position.x - transform.position.x < -1*xBound)
			{
				//transform.position = new Vector3(transform.position.x + player.GetComponent<Rigidbody2D>().velocity.x, transform.position.y, transform.position.z);
				Vector3 destination= new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);
				destination = Vector3.Lerp(transform.position, destination, easing);
				transform.position = destination;
			}

			transform.position = new Vector3(transform.position.x, player.transform.position.y, transform.position.z);

		}
	}
}
