using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoR3 : MonoBehaviour
{
    public GoR2 gor2;
    void Start()
    {
        
    }
    void Update()
    {
        if (gor2.r3Activated)
        {
            gameObject.SetActive(true);
        }
        else gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
         gameObject.SetActive(true);
         if (other.CompareTag("Player"))
         {
             Debug.Log("충돌");
             //R1Q2TextBox.Instance.PlayText();  // 텍스트 작성 시 활성화
             SceneManager.LoadScene("4_Room3");
             //enabled = false;

             //gameObject.SetActive(false);

         }
    }
}
