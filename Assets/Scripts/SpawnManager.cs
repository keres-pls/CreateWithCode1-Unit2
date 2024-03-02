using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    /// <summary>
    /// Collection of prefabs that can be spawned
    /// </summary>
    public GameObject[] animalPrefabs;

    /// <summary>
    /// Time between spawns in seconds
    /// </summary
    public float spawnRate = 2.0f;

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

    private void Start()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        float xPos = Random.Range(xRange * -1, xRange);
        Vector3 spawnPos = new Vector3(xPos, transform.position.y, transform.position.z);
        GameObject.Instantiate(animalPrefabs[animalIndex], spawnPos, transform.rotation);
        
    }


    void Update()
    {
        if(delayCounter < spawnRate + spawnRateFuzz)
        {
            delayCounter += Time.deltaTime;
        }
        else
        {
            delayCounter = 0.0f;
            spawnRateFuzz = Random.Range(spawnRateMaxFuzz * -1, spawnRateMaxFuzz);
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            float xPos = Random.Range(xRange * -1, xRange);
            Vector3 spawnPos = new Vector3(xPos, transform.position.y, transform.position.z);
            GameObject.Instantiate(animalPrefabs[animalIndex], spawnPos, transform.rotation);
            
        }
        
    }
}
