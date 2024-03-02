using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float spawnDogInterval = 1.0f;
    private float spawnDogCounter = 0.0f;
    private bool coolDownDog = false;

    // Update is called once per frame
    void Update()
    {
 
        if (Input.GetKeyDown(KeyCode.Space) && !coolDownDog)
        {
            SpawnDog();
            coolDownDog = true;
        }
        if (coolDownDog)
        {
            if (spawnDogCounter < spawnDogInterval)
            {
                spawnDogCounter += Time.deltaTime;
            }
            else
            {
                spawnDogCounter = 0.0f;
                coolDownDog = false;
            }
        }
    }


    void SpawnDog()
    {
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
    }

}