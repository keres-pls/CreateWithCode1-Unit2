using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;
    private float spawnInterval = 4.0f;

    /// <summary>
    /// Extents on x axis that animals can be spawned within
    /// </summary>
    public float xRange = 15;

    private float delayCounter = 0.0f;
    /// <summary>
    /// The maximum variability between spawn delays
    /// </summary>
    public float spawnRateMaxFuzz = 1.0f;

    private float spawnRateFuzz;



    void Update()
    {
        if (delayCounter < spawnInterval + spawnRateFuzz)
        {
            delayCounter += Time.deltaTime;
        }
        else
        {
            delayCounter = 0.0f;
            spawnRateFuzz = Random.Range(spawnRateMaxFuzz * -1, spawnRateMaxFuzz);
            SpawnRandomBall();
        }
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        int ballIndex = Random.Range(0, ballPrefabs.Length);
        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
    }


}
