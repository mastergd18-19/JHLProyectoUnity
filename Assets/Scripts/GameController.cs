using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public Canvas canvas;
    public GameObject Obstacle;
    public Vector3 Spawnvalues;
    public int ObstacleCount;
    public float Spawnwait;
    public float Startwait;
    public GameObject clone;
    public GameObject obj;



    // Start is called before the first frame update
    void Start()
    {
        canvas.gameObject.SetActive(false);
        StartCoroutine(spawnwaves());
    }

    /*void OnTriggerEnter(Collider Player)
    {
        canvas.gameObject.SetActive(true);
    }*/

    IEnumerator spawnwaves()
    {
        yield return new WaitForSeconds(Startwait);

        while (true)
        {
            for (int i = 0; i < ObstacleCount; i++)
            {
                Vector3 Spawnposition = new Vector3(Spawnvalues.x, Spawnvalues.y, Random.Range(0, 18));
                Quaternion Spawnrotation = Quaternion.identity;
                clone = Instantiate(Obstacle, Spawnposition, Spawnrotation);
                Debug.Log("spawn");                
            }
            yield return new WaitForSeconds(Spawnwait);
        }

    }

    
}
