using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField]
    List<GameObject> obstaclePrefabs;
    [SerializeField]
    float delayMin;
    [SerializeField]
    float delayMax;

    private float timer;
    void Start()
    {
        GenerateDelay();
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            SpawnObstacle();

            GenerateDelay();
        }
    }

    private void SpawnObstacle()
    {
        int obstacleType = ((int)Random.Range(0, obstaclePrefabs.Count));
        GameObject obstacle = Instantiate(obstaclePrefabs[obstacleType], transform);
        float angle = ((int)Random.Range(0, 4)) * 90;
        obstacle.transform.localRotation = Quaternion.AngleAxis(angle, transform.forward);
    }

    private void GenerateDelay()
    {
        timer = Random.Range(delayMin, delayMax);
    }

}
