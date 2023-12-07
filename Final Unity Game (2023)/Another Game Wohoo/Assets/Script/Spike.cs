using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{

    //variable for the game
    Health damage;

    public GameObject hitPoints;


    // Start is called before the first frame update
    void Start()
    {
        damage = hitPoints.GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Player")
        {
            damage.TakeDamage(1);
        }
    }
}
