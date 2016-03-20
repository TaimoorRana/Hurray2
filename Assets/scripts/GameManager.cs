using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {
	int points = 0;
	public GameObject[] student;
	public GameObject[] location;
	List<GameObject> studentsCreated;
	bool gameStarted = false;
	public GameObject player;
	public Menu menu;

	public int studentsCount = 0;
	// Use this for initialization
	void Start () {
		
		studentsCreated = new List<GameObject>();
		int locationIndex = 0;
		int studentIndex = 0 ;
		while(studentsCount != 0){
			if(locationIndex >= location.Length)
				locationIndex = 0;
			if(studentIndex >= student.Length)
				studentIndex = 0;
			studentsCreated.Add((GameObject)Instantiate(student[studentIndex++],location[locationIndex++].transform.position,Quaternion.identity));

			//Instantiate(student[studentIndex++],location[locationIndex++].transform.position,Quaternion.identity);
			points++;
			studentsCount--;
		}
		gameStarted = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(gameStarted){
			foreach (GameObject student in studentsCreated){

				if (student != null && Mathf.Abs(player.transform.position.z - student.transform.position.z) >= 8f){
					Debug.Log("Lost");
					menu.Restart();
				}
			}
		}
	}

	public void reducePoint(){
		points--;
	}

	public int getPoints(){
		return points;
	}


}