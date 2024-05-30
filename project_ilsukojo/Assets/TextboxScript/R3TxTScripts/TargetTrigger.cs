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
            //enabled = false;    //Update ���� �ߴ�
        }
    }

private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Debug.Log("�浹");
            //player.SetActive(false);    // ī�޶������ ���� �÷��̾��Ȱ��ȭ
            //Debug.Log("Event triggered!");
            TargetTextBox.Instance.PlayText();
            playerMove.canMove = false;



        }
    }
}
