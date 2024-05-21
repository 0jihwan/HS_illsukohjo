using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintTrigger : MonoBehaviour
{

    [SerializeField]
    private PlayerMove playerMove;
    void Start()
    {
        //gameObject.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

                HintTextBox.Instance.PlayText();
                playerMove.moveSpeed = 0;

                gameObject.SetActive(false);

        }
    }
}
