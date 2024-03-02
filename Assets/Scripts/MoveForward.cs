using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 40.0f;
    public float topBound = 30.0f;
    public float bottomBound = -20.0f;

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (transform.position.z <  bottomBound || transform.position.z > topBound)
        {
            GameObject.Destroy(this.gameObject);
        }
    }
}
