using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public GameObject player;
    public GameObject finish;
    private int counter = 1;

    // Use this for initialization
    void Start()
    {

        finish.transform.position = new Vector3(30 * (counter + 1) * 6 + 50, 2, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        if (counter > 0)
        {
            if (transform.position.x - player.transform.position.x < -90)
            {

                counter--;
                transform.position = new Vector3(player.transform.position.x + 90, Random.Range(-7, 2), 0);
            }
        }
    }
}
