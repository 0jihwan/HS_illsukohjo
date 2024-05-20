using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startTrigger : MonoBehaviour
{
    float timer;
    int startTime = 2;
    //private GameObject player;
    [SerializeField]
    private PlayerMove playerMove;
    void Start()
    {
        //player = GameObject.FindWithTag("Player");
        timer = 0f;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > startTime)
        {
            //player.SetActive(false);    // ī�޶������ ���� �÷��̾��Ȱ��ȭ
            //Debug.Log("Event triggered!");
            startTextBox.Instance.PlayText();
            playerMove.moveSpeed = 0;
            enabled = false;    //Update ���� �ߴ�
        }
    }
}
