using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class DoorOpenTrigger : MonoBehaviour
{
    //private GameObject player;
    public PassWordUION passworduion;
    float timer;

    [SerializeField]
    private YSBPlayerMove playerMove;
    void Start()
    {
        //player = GameObject.FindWithTag("Player");
        //Cursor.visible = false;
        timer = 0f;
    }
    void Update()
    {

        //player.SetActive(false);    // 카메라고정을 위해 플레이어비활성화
        //Debug.Log("Event triggered!");
        if (passworduion.PassWordSolve)
        {
            timer += Time.deltaTime;
            if (timer > 1.0f)
            {
                DoorOpenText.Instance.PlayText();
                playerMove.movespeed = 0;
                enabled = false;    //Update 루프 중단
            }
        }

    }
}
