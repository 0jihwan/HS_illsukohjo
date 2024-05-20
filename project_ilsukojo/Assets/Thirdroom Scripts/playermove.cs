using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    public float walkSpeed = 5f;
    public float runSpeed = 10f;
    public Transform cameraTransform;
    public float mouseSemsitivity = 2f;

    private CharacterController controller;
    private Vector3 playerVelocity;


    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float moveSpeed = Input.GetKey(KeyCode.LeftShift) ? runSpeed : walkSpeed;
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 move = transform.right * horizontal + transform.forward * vertical;
        controller.Move(move * moveSpeed * Time.deltaTime);

        playerVelocity.y += Physics.gravity.y * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);

        float mouseX = Input.GetAxis("Mouse X") * mouseSemsitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSemsitivity;
        transform.Rotate(Vector3.up * mouseX);

        Vector3 currentRotation = cameraTransform.rotation.eulerAngles;
        float desireRotationX = currentRotation.x - mouseY;
        if (desireRotationX > 180)
            desireRotationX -= 360;
        desireRotationX = Mathf.Clamp(desireRotationX, -90f, 90f);
        cameraTransform.rotation = Quaternion.Euler(desireRotationX,currentRotation.y,currentRotation.z);
    }
}
