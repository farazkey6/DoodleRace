using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMove : MonoBehaviour {

    public GameObject player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (transform.position.x - player.transform.position.x < -50)
        {

            transform.position = new Vector3(player.transform.position.x + 80,0 , 0);
        }
    }
}
