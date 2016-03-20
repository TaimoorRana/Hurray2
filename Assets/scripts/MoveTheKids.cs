using UnityEngine;
using System.Collections;

public class MoveTheKids : MonoBehaviour {


    public float maxspeed = 1.5f;
    float time = 0;
    float newtime = 0;
    float movetime = 0;
    int direction = 1;
    bool facingright = true;
    bool move = false;
    bool ismovig = false;
    Animator anim;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
       // float move1 = Input.GetAxis("Vertical");
        //float movee = Input.GetAxis("Horizontal");


        anim.SetFloat("moveRight", Mathf.Abs(GetComponent<Rigidbody>().velocity.x));
      //  anim.SetFloat("moveRight", Mathf.Abs(movee));
        // GetComponent<Rigidbody>().velocity = new Vector3(movee * maxspeed, GetComponent<Rigidbody>().velocity.y, GetComponent<Rigidbody>().velocity.z);

        GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.x, GetComponent<Rigidbody>().velocity.y, maxspeed);



        if (!ismovig) {
        time += Time.deltaTime;
        if (time > Random.Range(1.0F, 4.0F))
        {
            move = true;
            movetime = Random.Range(0.5F, 2F);
            direction = Random.Range(-1, 2);
                ismovig = true;

        }
        }

        if (move) {
            newtime += Time.deltaTime;
            if (newtime < movetime)
            {
                if (transform.localPosition.x < -1.2 || transform.localPosition.x > 1.2)
                {
                    direction = -direction;
                }
              
                    GetComponent<Rigidbody>().velocity = new Vector3(maxspeed * direction, GetComponent<Rigidbody>().velocity.y, GetComponent<Rigidbody>().velocity.z);

           

            }
            else {
                move = false;
                time = 0;
                newtime = 0;
                    movetime = 0;
                direction = 1;
                ismovig = false;

            }

        }


        // GetComponent<Rigidbody>().velocity = new Vector3( maxspeed, GetComponent<Rigidbody>().velocity.y, GetComponent<Rigidbody>().velocity.z);

        if (GetComponent<Rigidbody>().velocity.x < 0 && facingright)
        {
            flip();

        }
        else if (GetComponent<Rigidbody>().velocity.x > 0 && !facingright)
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
            Destroy(gameObject); 
        }  
    }
}
