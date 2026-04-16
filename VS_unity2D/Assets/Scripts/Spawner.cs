using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour
{
    public Transform[] spawnPoint;

    float time = 0.2f;
    float currentTime = 0f;

    void Awake()
    {
        spawnPoint = GetComponentsInChildren<Transform>();
    }
    void Update()
    {
        // GameManager.instance.pool.Get(1);

        currentTime += Time.deltaTime;
        if (currentTime > time)
        {
            int ranPoint = Random.Range(0, 15);
            Instantiate(GameManager.instance.pool.Get(Random.Range(0, 2)), spawnPoint[ranPoint]);
            currentTime = 0;
        }
    }

}
