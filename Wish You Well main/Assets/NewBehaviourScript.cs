using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
	public int num =0;
	public bool onground=false;
	// Use this for initialization
	void Start () {
	
	}

	void OnCollisionExit2D (Collision2D cll){
		if (cll.collider.gameObject.tag =="ground"){
			onground=false;
		}
			 
	}

	void OnCollisionEnter2D (Collision2D cll){
		if (cll.collider.gameObject.tag == "ground") {
			onground = true;
		}
	}
	// Update is called once per frame
	void Update () { 
		
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.position = new Vector3 (transform.position.x + .25f, transform.position.y, transform.position.z);
		}
		if  (onground == true){ 
			if (Input.GetKeyDown (KeyCode.UpArrow)) {
				Rigidbody2D rb = GetComponent<Rigidbody2D> ();
				rb.isKinematic = false;
				rb.velocity = new Vector3 (0f, 8f, 0f);
		}}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.position = new Vector3 (transform.position.x - .25f, transform.position.y, transform.position.z);
		}
	}
}
