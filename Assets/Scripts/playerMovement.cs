using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public float speed;
    Rigidbody rb;
    Vector3 vel;
    public float acceleration;
    public float deceleration;
    float lateral;
    float forward;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = vel;
        Acceleration();
        Movement();
    }

    void Movement ()
    {
        
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector3(-speed, rb.velocity.y, rb.velocity.z);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, -speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector3(speed, rb.velocity.y, rb.velocity.z);
        }

    }

    void Acceleration ()
    {

        forward = Input.GetAxis("Forward");
        lateral = Input.GetAxis("Lateral");

        if (Input.GetAxisRaw("Lateral") != 0)
        {
            vel.x = acceleration * lateral * Time.deltaTime;
        }

        else if (Input.GetAxisRaw("Lateral") ==0)
        {
            vel.x = deceleration * lateral * Time.deltaTime;
        }

        if (Input.GetAxisRaw("Forward") != 0)
        {
            vel.z = acceleration * forward * Time.deltaTime;
        }

        else if (Input.GetAxisRaw("Forward") == 0)
        {
            vel.z = deceleration * forward * Time.deltaTime;
        }

        vel.x = Mathf.Clamp(vel.x, -speed, speed);
        vel.z = Mathf.Clamp(vel.z, -speed, speed);
        

        //if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            //if (acceleration >= 0 && acceleration < 100)
            {
              //  acceleration++;
            }
        }

        //else
        {
            //if (acceleration != 0)
            {
                //acceleration--;
            }
        }
        
        
        


        //if (Input.GetAxis("Horizontal") != 0)
        {
            //speed = acceleration * horizontal;
        }

        //if (Input.GetAxis("Horizontal") != 0)
        {
           // speed = acceleration * horizontal;
        }
    }
}
