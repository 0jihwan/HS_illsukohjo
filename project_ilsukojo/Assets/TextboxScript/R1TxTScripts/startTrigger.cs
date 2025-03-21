using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startTrigger : MonoBehaviour
{
    float timer;
    int startTime = 4;
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
            //player.SetActive(false);    // 카메라고정을 위해 플레이어비활성화
            //Debug.Log("Event triggered!");
            startTextBox.Instance.PlayText();
            playerMove.moveSpeed = 0;
            enabled = false;    //Update 루프 중단
        }
    }
}
