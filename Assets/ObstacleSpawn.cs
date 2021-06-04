using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{
    public GameObject obst;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ObstacleSpawns", 1.0f, 2.0f);
    }
    private void ObstacleSpawns()
    {
        float x = Random.Range(10,10000);
        Vector3 foodposition = new Vector3(x, 1, 0);
        Instantiate(obst, foodposition, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
