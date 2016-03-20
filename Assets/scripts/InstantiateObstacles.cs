using UnityEngine;
using System.Collections;

public class InstantiateObstacles : MonoBehaviour {
    public GameObject[] pref;
    public GameObject reference;
    public GameObject obstacles;
    float temps = 0.0f;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float waitTime = Random.Range(5f,10.0f);
        
            if (temps>=waitTime)
            {
            (Instantiate(pref[Random.Range(0, pref.Length)] , new Vector3(Random.Range(-1.5F, 1.5F), 0.2f, reference.transform.position.z + Random.Range(5.0F, 10.0F)), Quaternion.identity) as  GameObject).transform.parent = this.transform; 

            temps = 0.0f;
            }
            else
            temps = temps + Time.deltaTime;

        //StartCoroutine(Example(waitTime));
        //Instantiate(pref,new Vector3(Random.Range(-1.5F, 1.5F), 0.2f,reference.transform.position.z+ Random.Range(5.0F, 10.0F)), Quaternion.identity);
	}
    IEnumerator Example(float WT)
    {
        print(Time.time);
        yield return new WaitForSeconds(WT);
        print(Time.time);
    }
}
