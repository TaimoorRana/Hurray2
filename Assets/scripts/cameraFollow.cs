using UnityEngine;
using System.Collections;

public class cameraFollow : MonoBehaviour {
	public GameObject bird;
    public float cameradistance;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 pos = transform.position;

		pos.z = bird.transform.position.z- cameradistance;

		transform.position = pos;
	
	}

	void OnTriggerEnter(Collider coll){
		if (coll.gameObject.tag == "bg") {
            Debug.Log("dddd");
			Vector2 pos1 = coll.gameObject.transform.position;
			pos1.x += 40.96f;
			coll.gameObject.transform.position = pos1;
		}

	}
}
