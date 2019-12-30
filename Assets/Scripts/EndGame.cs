using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EndGame : MonoBehaviour
{
    public Canvas canvas;
    
    void OnTriggerEnter(Collider other)
    {
        
        SceneManager.LoadScene("Menu");

    }
}
