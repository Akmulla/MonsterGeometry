using UnityEngine;
using System.Collections;

public class MoveHand : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector3 movement=Vector2.zero;
    public float speed;
    public float rotationSpeed;
    public GameObject hand;
    public CircleCollider2D overlapArea;
    float angle;

    void Start()
    {
        rb = hand.GetComponent<Rigidbody2D>();
        overlapArea = GetComponent<CircleCollider2D>();
        angle = 0;
    }

    
    void Update()
    {
        Move();
    }


    void FixedUpdate()
    {
       rb.velocity = movement;
       rb.MoveRotation(angle*rotationSpeed);
    }
    void Move()
    {
        Touch[] touches;
        if (Input.touchCount > 0)
        {
            touches = Input.touches;
            for (int i = 0; i < touches.Length; i++)
            {
                Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touches[i].position);
                touchPosition.z = 0;
                if (overlapArea.OverlapPoint(touchPosition))
                {
                    //transform.position = Vector3.Lerp(transform.position, touchPosition, speed);


                    Vector3 moveDirection = touchPosition - hand.transform.position;
                    movement = moveDirection * speed;

                    if (touches[i].deltaPosition.magnitude > 0.2f)
                    {
                        angle = Mathf.Atan2(moveDirection.x, -moveDirection.y) * Mathf.Rad2Deg;
                    }
                    //transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

                    //hand.transform.rotation = Quaternion.Lerp(hand.transform.rotation, Quaternion.AngleAxis(angle, Vector3.forward), rotationSpeed);


                    //рабочая версия
                    //Quaternion turn = Quaternion.Lerp(hand.transform.rotation, Quaternion.AngleAxis(angle, Vector3.forward), rotationSpeed);
                    //rb.MoveRotation(turn.eulerAngles.z);
                }
                //else
                //{
                //    movement = Vector2.zero;
                //}
            }
        }
        else
        {
            movement = Vector2.zero;
        }

    }

    
}
