using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPUTrigger : MonoBehaviour
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
        if(CPUTextBox.Instance.isdone == true)
        {
            playerMove.canMove = true;
            gameObject.SetActive(false);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Debug.Log("충돌");
            //player.SetActive(false);    // 카메라고정을 위해 플레이어비활성화
            //Debug.Log("Event triggered!");
            CPUTextBox.Instance.PlayText();
            playerMove.canMove = false;




        }
    }
}
