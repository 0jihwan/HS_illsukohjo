using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshPlayerMove : MonoBehaviour
{
    public float speed = 5.0f; // �÷��̾��� �̵� �ӵ��� �����մϴ�.

    void Update()
    {
        // �Է¿� ���� x�� y ���������� �̵� ���͸� ����մϴ�.
        float moveX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float moveY = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        // ���� ��ġ�� �̵� ���͸� ���Ͽ� �� ��ġ�� ����մϴ�.
        //transform.position += new Vector3(moveX, 0, moveY);

        Vector3 temp = transform.position;
        temp.x += moveX;
        temp.z += moveY;

        transform.position = temp;
    }
}