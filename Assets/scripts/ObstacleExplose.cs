using UnityEngine;
using System.Collections;

public class ObstacleExplose : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Debug.Log("explode");
            Vector2 pos1 = coll.gameObject.transform.position;
            GetComponent<Rigidbody>().AddTorque(new Vector3(50f,400f, 650f));


            GetComponent<Rigidbody>().AddForce(new Vector3(50f, 200f, 950f));
        }

    }
}
