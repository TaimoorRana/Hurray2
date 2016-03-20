using UnityEngine;
using System.Collections;

public class ControlRoad : MonoBehaviour {
    public GameObject[] env=new GameObject[3];
    public GameObject CameraMove;
    float PosIntEnv;
    int i=0;
    int mul=1;
    // Use this for initialization
    void Start () {
        PosIntEnv = CameraMove.transform.position.z;

    }
	
	// Update is called once per frame
	void Update () {
        
        if (Mathf.Abs(CameraMove.transform.position.z- PosIntEnv)  > 17.19742f*mul)
        {
            env[i].transform.position = new Vector3 (env[i].transform.position.x,env[i].transform.position.y,env[i].transform.position.z+ 17.19742f*3);
            i++;
            mul++;
            if (i == 3)
                i = 0;
        }
            
    }
}
