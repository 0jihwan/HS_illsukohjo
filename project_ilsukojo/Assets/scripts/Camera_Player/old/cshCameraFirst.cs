using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class cshCameraFirst : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    private Vector3 offset = new Vector3(0, 1.4f, 0);

    public float sensitivity = 2.0f; //���콺����
    
    private float maxYAngle = 70.0f;
    private float rotationY = 0.0f;
    public int i = 1;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        //Cursor.visible = false;

    }
    // LateUpdate -> make sure that update after all other update happens
    void Update()
    {
        // offset the camera to put camera behind the vehicle
        transform.position = player.transform.position + offset;

        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        // ���콺 X �࿡ ���� ī�޶� �¿� ȸ��
        transform.Rotate(0, mouseX * sensitivity, 0);

        // ���콺 Y �࿡ ���� ī�޶� ���� ȸ��
        rotationY -= mouseY * sensitivity;
        rotationY = Mathf.Clamp(rotationY, -maxYAngle, maxYAngle);
        Camera.main.transform.localRotation = Quaternion.Euler(rotationY, transform.localEulerAngles.y, 0);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (i == 1)
            {
                Cursor.lockState = CursorLockMode.None;
                i--;
            }
            else if(i == 0)
            {
                i++;
                Cursor.lockState = CursorLockMode.Confined;

            }
            //
        }
    }
}
