using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour {

    private Rigidbody2D rb;
    private int maxSpeed = 15;
    private int jump = 8;
            

	// Use this for initialization
	void Start () {

        Cursor.visible = false;
        rb = GetComponent< Rigidbody2D > ();
        rb.freezeRotation = true;
	}
	
	// Update is called once per frame
	void Update () {
        
        //if (speed < maxSpeed)
        //{
        //    speed++;
        //    rb.AddForce(Vector2.right * speed);
        //}
        //else
        //{
        //    rb.AddForce(Vector2.right * speed);
        //}
        //transform.eulerAngles = new Vector2(0, 0);
        rb.AddForce(Vector2.right * maxSpeed);

        
    }
    
    void FixedUpdate()
    {

        if (Input.GetKeyDown("space"))
        {
            
            rb.velocity = new Vector2(rb.velocity.x , jump);
        }
    }
}
