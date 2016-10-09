using UnityEngine;
using System.Collections;

public class Fly : MonoBehaviour {

    
    public float speed;
    public float yLimit;
    float t = 0f;
    float cosine;

	// Use this for initialization
	void Start () {
        cosine = Mathf.Cos(t);
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = new Vector3(transform.position.x + speed, 
            transform.position.y + (yLimit * cosine), 0f);
        if (transform.position.y > Mathf.Cos(t))
        {
            cosine *= -1f;
            t += Time.deltaTime;
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Wall" || coll.gameObject.tag == "Edge")
        {
            speed *= -1;

        }

        if (coll.gameObject.tag == "Player")
        {
            //player loses
        }
    }
}
