using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingEnemy : MonoBehaviour
{ 
    public float speed;

    public bool up = true;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (up)
        {
            transform.position = new Vector2(transform.position.y - speed, transform.position.x);
        }

        else
        {
            transform.position = new Vector2(transform.position.y + speed, transform.position.x);
        }

    }

    void OnTriggerEnter2D(Collider2D coll)
    {


        if (coll.tag == "Wall" && up == true)
        {
            up = false;
        }

        else if (coll.tag == "Wall" && up == false)
        {
            up = true;
        }
    }
}
