using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R2startTrigger : MonoBehaviour
{
    float timer;
    int startTime = 2;
    //private GameObject player;
    [SerializeField]
    private YSBPlayerMove playerMove;
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
            R2startTextBox.Instance.PlayText();
            playerMove.movespeed = 0;
            enabled = false;    //Update 루프 중단
        }
    }
}
