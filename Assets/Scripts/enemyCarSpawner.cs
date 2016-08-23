using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class enemyCarSpawner : MonoBehaviour
{

    public GameObject[] enemyCars;
    int carNumber;
    float maxEnemyCarPosition = 1.4f;
    float minEnemyCarPosition = -1.4f;
    public float enemyCarSpawnDelayInitial = 2f;
    float minDelay = 0.5f;
    float maxDelay = 3f;
    float spawnTimer;
    float levelTimer;
    float initialLevelTimer = 10f;



    // Use this for initialization
    void Start()
    {
        spawnTimer = enemyCarSpawnDelayInitial;
        levelTimer = initialLevelTimer;
    }

    // Update is called once per frame
    void Update()
    {
        //Check if enemy car is already spawned
        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0)
        {
            Vector3 enemyCarSpawnPosition = new Vector3(Random.Range(minEnemyCarPosition, maxEnemyCarPosition), transform.position.y, transform.rotation.x);

            carNumber = Mathf.CeilToInt(Random.Range(0, 5));


            Instantiate(enemyCars[carNumber], enemyCarSpawnPosition, transform.rotation);

            spawnTimer = Random.Range(minDelay, maxDelay);

        }

        //Check if level up
        levelTimer -= Time.deltaTime;
        if (levelTimer <= 0)
        {
            if (minDelay >= maxDelay)
            {
                maxDelay = 0.5f;
                minDelay = 0.5f;
            }
            minDelay += minDelay * 0.5f;
            maxDelay -= maxDelay * 0.5f;
            levelTimer = initialLevelTimer;
        }
    }


}
