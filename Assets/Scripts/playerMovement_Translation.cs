using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement_Translation : MonoBehaviour
{
    public float speed;
    public bool moving;
    public bool direction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Movement();
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            direction = !direction;
            transform.rotation =transform.rotation * Quaternion.Euler(180f, 0f, 0f);

            

        }

    }

    void Movement()
    {
        //float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");


        if (direction)
        {
            transform.Translate(new Vector3(0, transform.position.y, 0) * speed * Time.deltaTime);
        }
        else
        {

            transform.Translate(new Vector3(0, transform.position.y, 0) * speed * Time.deltaTime);

        }
       
       
        /*else
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }*/

        /*if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        */
    }
}
