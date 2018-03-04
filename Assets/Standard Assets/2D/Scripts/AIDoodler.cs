using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIDoodler : MonoBehaviour {


    private Rigidbody2D rb;
    private int maxSpeed = 15;
    private int jump = 8;
    // Use this for initialization
    void Start () {

        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
    }
	
	// Update is called once per frame
	void Update () {

        rb.AddForce(Vector2.right * maxSpeed);
        if (transform.position.y < -6)
        {

            Jump();
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {

        float rand = Random.Range(1, 100);
        if (rand < 30)
        {
            Jump();
        }
    }

    private void Jump()
    {

        rb.velocity = new Vector2(rb.velocity.x, jump);
    }
}
