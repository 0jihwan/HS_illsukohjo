using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoR2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("�浹");
            //R1Q2TextBox.Instance.PlayText();  // �ؽ�Ʈ �ۼ� �� Ȱ��ȭ
            SceneManager.LoadScene("3_Room2");
            //enabled = false;

            //gameObject.SetActive(false);


        }
    }
}