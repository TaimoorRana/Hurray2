using UnityEngine;
using System.Collections;

public class MoveBackground : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider coll)
    {

        Debug.Log("dddd");
        if (coll.gameObject.tag == "bg")
        {
            Debug.Log("dddd");
            Vector3 pos1 = coll.gameObject.transform.position;
            pos1.z += 26.8f;
            coll.gameObject.transform.position = pos1;
        }

    }
}
