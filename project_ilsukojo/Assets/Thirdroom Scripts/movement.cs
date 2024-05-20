using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float movementSpeed;
    public Rigidbody playerR;
        
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            playerR.velocity = transform.forward * movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            playerR.velocity = transform.right * movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            playerR.velocity = -transform.forward * movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            playerR.velocity = -transform.right * movementSpeed * Time.deltaTime;
        }
    }
}
