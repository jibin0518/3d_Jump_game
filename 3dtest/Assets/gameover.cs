using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameover : MonoBehaviour
{

    public GameObject player;
    public GameObject block1;
    public GameObject block2;
    public GameObject block3;
    public GameObject block4;
    public GameObject block5;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "player")
        {
            player.transform.position = new Vector3(0,2,0);
        }
        if (collision.gameObject.name == "player")
        {
            block1.transform.position = new Vector3(50, 0.18f, 110);
        }
        if (collision.gameObject.name == "player")
        {
            block2.transform.position = new Vector3(50, 0.18f, 125);
        }
        if (collision.gameObject.name == "player")
        {
            block3.transform.position = new Vector3(50, 0.18f, 140);
        }
        if (collision.gameObject.name == "player")
        {
            block4.transform.position = new Vector3(50, 0.18f, 158);
        }
        if (collision.gameObject.name == "player")
        {
            block5.transform.position = new Vector3(50, 0.18f, 175);
        }
    }
}
