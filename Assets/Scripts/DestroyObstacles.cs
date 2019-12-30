using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObstacles : MonoBehaviour
{
    public GameObject obj;

    void OnTriggerEnter(Collider other)
    {
        Destroy(obj);
    }
}
