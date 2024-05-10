using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshPlayerMove : MonoBehaviour
{
    public float speed = 5.0f; // 플레이어의 이동 속도를 조절합니다.

    void Update()
    {
        // 입력에 따라 x와 y 방향으로의 이동 벡터를 계산합니다.
        float moveX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float moveY = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        // 현재 위치에 이동 벡터를 더하여 새 위치를 계산합니다.
        //transform.position += new Vector3(moveX, 0, moveY);

        Vector3 temp = transform.position;
        temp.x += moveX;
        temp.z += moveY;

        transform.position = temp;
    }
}