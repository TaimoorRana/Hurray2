using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {
	int points = 0;
	public GameObject[] student;
	public GameObject[] location;
	public int studentsCount = 0;
	// Use this for initialization
	void Start () {
		int locationIndex = 0;
		int studentIndex = 0 ;
		while(studentsCount != 0){
			if(locationIndex >= location.Length)
				locationIndex = 0;
			if(studentIndex >= student.Length)
				studentIndex = 0;
			Instantiate(student[studentIndex++],location[locationIndex++].transform.position,Quaternion.identity);
			points++;
			studentsCount--;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void reducePoint(){
		points--;
	}

	public int getPoints(){
		return points;
	}
}