using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    Vector2 rotation = Vector2.zero;
    public float speed = 3;
    public Transform player;

    void Update()
    {
        Cursor.visible = false;
        rotation.y += Input.GetAxis("Mouse X");
        rotation.x += -Input.GetAxis("Mouse Y");
        transform.eulerAngles = (Vector2)rotation * speed;
        player.transform.eulerAngles = new Vector3(0, rotation.y * speed, 0);
    }
}
