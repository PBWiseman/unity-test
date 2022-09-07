using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{
    public GameObject obstacle;
    public float minX, minY, maxX, maxY, playerX;
    public float timeBetweenSpawn;
    private float spawnTime;
    private GameObject obj;

    // Update is called once per frame
    void Update()
    {
        if (Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }

    void Spawn()
    {
        float randX = Random.Range(minX, maxX);
        float randY = Random.Range(minY, maxY);
        obj = Instantiate(obstacle, transform.position + new Vector3(randX, randY, 0), transform.rotation);
    }
}