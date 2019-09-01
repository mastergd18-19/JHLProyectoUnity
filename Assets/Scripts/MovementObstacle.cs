using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementObstacle : MonoBehaviour
{
    public bool direction;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Movement();
    }

    void Movement()
    {
        //float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");


        if (direction)
        {
            transform.Translate(new Vector3(transform.position.x, 0, 0) * speed * Time.deltaTime);
        }
        else
        {

            transform.Translate(new Vector3(-transform.position.x, 0, 0) * speed * Time.deltaTime);

        }


    }
}
