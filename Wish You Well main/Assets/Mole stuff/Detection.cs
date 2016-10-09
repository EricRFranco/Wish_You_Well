using UnityEngine;
using System.Collections;

public class Detection : MonoBehaviour {
    GameObject mole;
    public float offset;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void Awake()
    {
         mole = this.transform.parent.gameObject;
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            
            mole.transform.Translate(0f, offset, 0f);
            
        }
    }

    void OnTriggerExit2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "Player")
        {
            mole.transform.Translate(0f, -offset, 0f);

        }
        
    }
}
