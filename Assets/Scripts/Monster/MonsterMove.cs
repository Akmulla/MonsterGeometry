using UnityEngine;
using System.Collections;

public class MonsterMove : MonoBehaviour
{
    public float speed;

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
       // transform.position = new Vector2(transform.position.x + speed, transform.position.y);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Boundary")
        {
            speed *= -1;
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Boundary")
        {
            speed *= -1;
        }
    }

    //public float speed;

    //private Rigidbody2D rb;
    //private bool turnRight;
    //void Start()
    //{
    //    rb = GetComponent<Rigidbody2D>();
    //    rb.velocity = Vector2.right * speed;
    //    turnRight = true;
    //}

    //void Update()
    //{
    //    if (turnRight)
    //    {
    //        rb.velocity = Vector2.right * speed;
    //    }
    //    else
    //    {
    //        rb.velocity = Vector2.left * speed;
    //    }
    //}


    //void OnCollisionEnter2D(Collision2D other)
    //{
    //    if (other.gameObject.tag == "Boundary")
    //    {
    //        if (other.gameObject.name == "rightBoundary")
    //        {
    //            rb.velocity = Vector2.left * speed;
    //            turnRight = false;
    //        }
    //        else
    //        {
    //            rb.velocity = Vector2.right * speed;
    //            turnRight = true;
    //        }
    //    }
    //}
}
