using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CRstart2Trigger : MonoBehaviour
{
    public CameraSwitcher cameraSwitcher;
    //private GameObject player;
    [SerializeField]
    private PlayerMove playerMove;
    void Start()
    {
        //player = GameObject.FindWithTag("Player");
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        //player.SetActive(false);    // 카메라고정을 위해 플레이어비활성화
        //Debug.Log("Event triggered!");
        if (cameraSwitcher.isdone)
        {
            CRstart2TextBox.Instance.PlayText();
            playerMove.moveSpeed = 0;
            enabled = false;    //Update 루프 중단
        }
    }
}
