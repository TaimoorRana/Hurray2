using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {
	public Menu menu;
	// Use this for initialization
	List<GameObject> students ;
	int count = 7;
	void Start () {
		students = new List<GameObject>();
		GameObject.FindGameObjectsWithTag("Kid");
	}
	
	// Update is called once per frame
	void Update () {
		if(count == 1){
			menu.Restart();
		}
		count = GameObject.FindGameObjectsWithTag("Kid").Length;

	}

	public void reduceStudentCount(){
		count--;
	}
}
