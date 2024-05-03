using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraMove : MonoBehaviour
{
    [SerializeField]
    private float mousespeed = 50f;

    private float MouseX;
    private float MouseY;
    public bool test;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {     
        if(test == false)
        {
        Rotate();        
        }
    }

    private void Rotate()
    {
        MouseX += Input.GetAxisRaw("Mouse X") * mousespeed * Time.deltaTime;
        MouseY -= Input.GetAxisRaw("Mouse Y") * mousespeed * Time.deltaTime;
        MouseY = Mathf.Clamp(MouseY, -70f, 90f);
        transform.localRotation = Quaternion.Euler(MouseY, MouseX, 0f);
    }
}
