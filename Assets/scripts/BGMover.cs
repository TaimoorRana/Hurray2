using UnityEngine;
using System.Collections;

public class BGMover : MonoBehaviour {

	// Use this for initialization
	public GameObject[] bgs;
	public float[] vitesses;
	public float limit;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		for (int i=0; i<bgs.Length; i++) {
		
			Vector2 pos = bgs[i].transform.position;
			pos.y-=vitesses[i];
			bgs[i].transform.position = pos;

			if(bgs[i].transform.position.y <= limit){

				pos.y += 2 * Mathf.Abs(limit);
				bgs[i].transform.position = pos;
			}


		}
	
	}
}
