using UnityEngine;
using System.Collections;

public class Worm : MonoBehaviour {

    public float speed = 1f;
    

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(transform.position.x + speed, transform.position.y, 0f);

    }

    void OnCollisionEnter2D (Collision2D coll)
    {
        if (coll.gameObject.tag == "Wall")
        {
            speed *= -1;
            
        }
        
    }
}
