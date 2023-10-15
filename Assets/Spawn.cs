using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject obstacle;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    public float timeBetweenSpawn;

    private float spawnTime;

   

    // Update is called once per frame
    void Update()
    {
        //if time passed is greater than spawn time
        if (Time.time > spawnTime)
        {
            Spawning();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }

    void Spawning()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Instantiate(obstacle, transform.position + new Vector3(randomX, randomY,0), transform.rotation);
    }
}
