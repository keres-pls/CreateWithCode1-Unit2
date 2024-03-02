using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float _horizontalInput;
    public float Speed = 10.0f;
    public float xRange = 10;
    public GameObject projectilePrefab;

    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * _horizontalInput * Speed * Time.deltaTime);
        transform.position = new Vector3(Math.Clamp(transform.position.x, -1 * xRange, xRange), transform.position.y, transform.position.z);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject.Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        }
    }
}
