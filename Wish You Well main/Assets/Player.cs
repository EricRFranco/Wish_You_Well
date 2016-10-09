using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public int num =0;
	public bool onground=false;
	Animator anim;
	public GameObject manager;
	//Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}

	void OnCollisionExit2D (Collision2D cll){
		if (cll.collider.gameObject.tag =="ground"){
			onground=false;
		}
			 
	}

	void OnCollisionEnter2D (Collision2D cll){
		if (cll.collider.gameObject.tag == "ground") {
			onground = true;
			anim.SetTrigger("Hit ground");
		}
	}

	void OnTriggerEnter2D(Collider2D cll)
	{
		if (cll.gameObject.tag == "enemy")
		{
			manager.SendMessage("GameOver");
		}
		if(cll.gameObject.tag == "save")
		{
			manager.SendMessage("SaveCoin");
			cll.gameObject.SendMessage("Disappear");
		}
	}
	// Update is called once per frame
	void Update () { 
		anim.ResetTrigger("jump");
		if(manager.GetComponent<Game_manager>().state == 1)
		{
			if (Input.GetKey (KeyCode.RightArrow)) {
				transform.position = new Vector3 (transform.position.x + .25f, transform.position.y, transform.position.z);
			}
			if  (onground == true){ 
				if (Input.GetKeyDown (KeyCode.Space)) {
					anim.ResetTrigger("Hit ground");
					Rigidbody2D rb = GetComponent<Rigidbody2D> ();
					rb.isKinematic = false;
					rb.velocity = new Vector3 (0f, 10f, 0f);
					anim.SetTrigger("jump");
				}
			}
			if (Input.GetKey (KeyCode.LeftArrow)) {
				transform.position = new Vector3 (transform.position.x - .25f, transform.position.y, transform.position.z);
			}
		}
	}
}
