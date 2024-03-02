using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 30.0f;
    public float bottomBound = -20.0f;

    void Update()
    {
        if (transform.position.z < bottomBound) 
        {
            GameObject.Destroy(this.gameObject);
            Debug.Log("Game Over");
        }
        else if (transform.position.z > topBound)
        {
            GameObject.Destroy(this.gameObject);
        }
    }
}
