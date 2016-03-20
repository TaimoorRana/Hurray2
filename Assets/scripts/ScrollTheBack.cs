using UnityEngine;
using System.Collections;

public class ScrollTheBack : MonoBehaviour {
	public float speed=0;
	float pos=0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	

		pos += speed;
		if (pos > 1.0f)
			pos -= 1.0f;
		GetComponent<Renderer>().material.mainTextureOffset = new Vector2 (0, pos);

	}
}
