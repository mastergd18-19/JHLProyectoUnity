using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float Tumble;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody.angularvelocity = Random.insideUnitSphere * Tumble;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
