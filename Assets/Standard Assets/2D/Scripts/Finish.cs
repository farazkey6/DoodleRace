using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{

    public GameObject player;
    //private GUIText message;
    public static int finished = 0;
    private int temp = 1;
    public static bool done = false;
    // Use this for initialization
    void Start()
    {
       // message = GetComponent<GUIText>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "AI" && !done)
        {

            temp++;
        }
        else if (collision.gameObject.tag == "Player")
        {

            done = true;
            //finished = temp;
            //message.text = "Finished " + finished;
        }
    }

    private void OnGUI()
    {

        if (done)
        {

            finished = temp;
            GUI.Label(new Rect(player.transform.position.x, 0, 1000, 100), "Your place " + finished);
        }
    }
}
