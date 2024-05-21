using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R1Q1Trigger : MonoBehaviour
{
    [SerializeField]
    private PlayerMove playerMove;
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("�浹");
            //player.SetActive(false);    // ī�޶������ ���� �÷��̾��Ȱ��ȭ
            //Debug.Log("Event triggered!");
            R1Q1TextBox.Instance.PlayText();
            Debug.Log("Event triggered!");
            playerMove.moveSpeed = 0;

            gameObject.SetActive(false);


        }
    }
}
