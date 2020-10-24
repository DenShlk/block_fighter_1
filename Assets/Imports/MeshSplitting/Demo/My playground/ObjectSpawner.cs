using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using Random = UnityEngine.Random;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField]
    List<GameObject> prefabs;
    [SerializeField]
    float minX, maxX;
    [SerializeField]
    float minDelay, maxDelay;

    private float timer;

    private void Start()
    {
        GenerateDelay();
    }

    private void GenerateDelay()
    {
        timer = Random.Range(minDelay, maxDelay);
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            Vector3 position = transform.position;
            position.x = Random.Range(minX, maxX);
            GameObject spawned = Instantiate(prefabs[Random.Range(0, prefabs.Count)]);
            spawned.transform.position = position;
            GenerateDelay();
        }
    }
}
