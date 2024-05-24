using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    public float moveSpeed;
    public float gravity = -9.81f;
    private Vector3 moveForce;

    private CharacterController characterController;

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }
    // Update is called once per frame
    private void Update()
    {
        if (characterController.isGrounded)
        {
            moveForce.y = 0f;
        }
        else
        {
            moveForce.y += gravity * Time.deltaTime;
        }
        characterController.Move(moveForce * Time.deltaTime);
    }

    public void MoveTo(Vector3 direction)
    {
        direction = transform.rotation * new Vector3(direction.x, 0, direction.z);

        //moveForce = new Vector3(direction.x * moveSpeed, moveForce.y, direction.z * moveSpeed);
        moveForce.x = direction.x * moveSpeed;
        moveForce.z = direction.z * moveSpeed;
    }
}
