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
             Debug.Log("�浹");
             //R1Q2TextBox.Instance.PlayText();  // �ؽ�Ʈ �ۼ� �� Ȱ��ȭ
             SceneManager.LoadScene("4_Room3");
             //enabled = false;

             //gameObject.SetActive(false);

         }
    }
}
