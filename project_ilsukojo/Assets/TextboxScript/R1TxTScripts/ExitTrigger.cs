using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitTrigger : MonoBehaviour
{
    [SerializeField]
    private PlayerMove playerMove;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("충돌");
            //R1Q2TextBox.Instance.PlayText();  // 텍스트 작성 시 활성화

            playerMove.moveSpeed = 0;
            SceneManager.LoadScene("2_Crossroad");
            //enabled = false;

            //gameObject.SetActive(false);


        }
    }
}
