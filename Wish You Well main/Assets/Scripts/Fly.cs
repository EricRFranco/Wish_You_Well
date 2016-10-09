using UnityEngine;
using System.Collections;

public class Fly : MonoBehaviour {

    public float speed;
    public float yLimit = 0.5f;
    public float step = 0.1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(transform.position.x + speed,
                transform.position.y, 0f);
        
        
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Wall" || coll.gameObject.tag == "Edge")
        {
            speed *= -1;

        }

    }
}
