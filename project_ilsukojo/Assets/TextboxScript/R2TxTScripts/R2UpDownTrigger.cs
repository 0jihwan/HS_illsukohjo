using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R2UpDownTrigger : MonoBehaviour
{
    //private GameObject player;
    public UpDownState UDstate;
    public UpDownUIon UDui;

    [SerializeField]
    private YSBPlayerMove playerMove;
    void Start()
    {
        //player = GameObject.FindWithTag("Player");
        //Cursor.visible = false;
    }
    void Update()
    {
        
         //player.SetActive(false);    // 카메라고정을 위해 플레이어비활성화
         //Debug.Log("Event triggered!");
         if(!UDstate.UDsolve && playerMove.UDflag || UDui.flag)
        {
            R2UpDownTextBox.Instance.PlayText();
            playerMove.movespeed = 0;
            enabled = false;    //Update 루프 중단
        }
        
    }
}
