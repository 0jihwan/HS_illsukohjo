using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingTrigger : MonoBehaviour
{
    [SerializeField]
    private SC_FPSController playerMove;

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("충돌");
            //player.SetActive(false);    // 카메라고정을 위해 플레이어비활성화
            //Debug.Log("Event triggered!");

            bool allHiddenObjectsFound = PlayerPrefs.GetInt("Hidden01_found", 0) == 1 &&
                                         PlayerPrefs.GetInt("Hidden02_found", 0) == 1 &&
                                         PlayerPrefs.GetInt("Hidden03_found", 0) == 1 &&
                                         PlayerPrefs.GetInt("Hidden04_found", 0) == 1;

            if (allHiddenObjectsFound)
            {
                HiddenEndingTextBox.Instance.PlayText();
            }
            else
            {
                EndingTextBox.Instance.PlayText();
            }
            //Debug.Log("Event triggered!");
            playerMove.canMove = false;

            gameObject.SetActive(false);


        }
    }
}
