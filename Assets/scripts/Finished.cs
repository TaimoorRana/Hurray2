using UnityEngine;
using System.Collections;

public class Finished : MonoBehaviour {

  public GameObject player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Debug.Log("finished");
            /* Vector2 pos1 = coll.gameObject.transform.position;
             pos1.x += 40.96f;*/
            player.GetComponent<cameraFollow>().enabled = false;
        }

    }
}
