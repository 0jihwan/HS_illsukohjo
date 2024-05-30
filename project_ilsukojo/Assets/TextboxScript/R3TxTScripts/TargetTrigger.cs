using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetTrigger : MonoBehaviour
{
    [SerializeField]
    private SC_FPSController playerMove;
    void Start()
    {
        //Cursor.visible = false;
        //Cursor.lockState = CursorLockMode.Locked;
    }
    private void Update()
    {
        if (TargetTextBox.Instance.isdone == true)
        {
            playerMove.canMove = true;
            gameObject.SetActive(false);
            //enabled = false;    //Update 루프 중단
        }
    }

private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Debug.Log("충돌");
            //player.SetActive(false);    // 카메라고정을 위해 플레이어비활성화
            //Debug.Log("Event triggered!");
            TargetTextBox.Instance.PlayText();
            playerMove.canMove = false;



        }
    }
}
