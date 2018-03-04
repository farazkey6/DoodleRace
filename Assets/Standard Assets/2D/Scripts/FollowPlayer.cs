using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public GameObject player;

    private Vector3 offset;
	// Use this for initialization
	void Start () {

        offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    private void LateUpdate()
    {

        transform.position = new Vector3(player.transform.position.x + 10, 0, -10);
    }
}
