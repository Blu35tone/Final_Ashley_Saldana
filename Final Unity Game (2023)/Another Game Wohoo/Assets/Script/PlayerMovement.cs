using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //variables for the game
    float speed;
    float move;

    float a;

    float jump;
    bool isJumping;

    Rigidbody2D rb;

    Health damage;

    public GameObject hitPoints;

    // Start is called before the first frame update
    void Start()
    {
        speed = 13f;
        jump = 450;

        rb = GetComponent<Rigidbody2D>();

        a = 0;

        damage = hitPoints.GetComponent<Health>();
    }


    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(speed * move, rb.velocity.y);

        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
            isJumping = true;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }

        if (other.gameObject.CompareTag("fall"))
        {
            transform.position = new Vector2(transform.position.x * a, transform.position.y * a);
            damage.TakeDamage(1);
        }
    }

}
