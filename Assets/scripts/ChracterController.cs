using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChracterController : MonoBehaviour {

    public float maxspeed = 3f;
    public float acceleration = 3f;
    bool facingright = true;
    bool facingleft = false;
    Animator anim;
    AudioSource source;
    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
		source = GetComponent<AudioSource>();
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }
	
	// Update is called once per frame
	void Update () {
       


    }


    void FixedUpdate() {

        float move = Input.acceleration.y;
        float movee = Input.acceleration.x;
       

        if (move > acceleration)
            move = acceleration;
        if (move < -acceleration)
            move = -acceleration;
        if (movee > acceleration)
            movee = acceleration;
        if (movee < -acceleration)
            movee = -acceleration;




        Debug.Log(Mathf.Abs(move));

        if (move != 0)
        {

        }
        else if (movee != 0)
        {

        }
       
        

        if (movee > 0.07 || movee < -0.07) {
        GetComponent<Rigidbody>().velocity = new Vector3(movee * maxspeed, GetComponent<Rigidbody>().velocity.y, GetComponent<Rigidbody>().velocity.z);
            anim.SetFloat("speedright", Mathf.Abs(movee));
        }

        else
            anim.SetFloat("speedright",0f);


        if (move > 0.07 || move < -0.07) { 
            GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.x, GetComponent<Rigidbody>().velocity.y, move * maxspeed);
            anim.SetFloat("speedforward", Mathf.Abs(move));
        }
        else
            anim.SetFloat("speedforward", 0f);

        if (movee < -0.07 && facingright)
        {
            flip();

        }
        else if (movee > 0.07 && !facingright)
        {
            flip();

        }



    }

    void flip()
    {
        facingright = !facingright;
        Vector3 thescale = transform.localScale;
        thescale.x *= -1;
        transform.localScale = thescale; 
       
    }

	void OnCollisionEnter(Collision coll) {
		if (coll.gameObject.tag == "Wire"){
			source.Play();
		}
    }
}
