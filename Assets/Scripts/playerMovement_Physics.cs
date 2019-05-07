using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement_Physics : MonoBehaviour
{
    public float acceleration;
    private Rigidbody rb;
    public float t;
    public float rR;
    public bool moving;
    public float deceleration;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb = GetComponent<Rigidbody>();
        InvokeRepeating("checkSpeed", t, rR);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Movement();
        movementDeceleration();
    }
    void Movement()
    {
        //float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        //Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        Vector3 movement = new Vector3(0.0f, 0.0f, moveVertical);
        rb.AddForce(movement * acceleration);

        /*if (Input.GetAxis("Horizontal") != 0 | Input.GetAxis("Vertical") != 0)
        {
            moving = true;
        }
        else
        {
            moving = false;
        }
        */
    }

    void movementDeceleration ()
    {
        if (moving == false)
        {
            rb.angularDrag = deceleration;
        }
        else
        {
            rb.angularDrag = 0.05f;
        }

    }

    void checkSpeed ()
    {
        Debug.Log("Velocidad en x:" + rb.velocity.x);
        Debug.Log("Velocidad en y:" + rb.velocity.y);
        Debug.Log("Velocidad en z:" + rb.velocity.z);
    }

}
