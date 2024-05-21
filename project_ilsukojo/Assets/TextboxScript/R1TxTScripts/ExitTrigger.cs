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
            Debug.Log("�浹");
            //R1Q2TextBox.Instance.PlayText();  // �ؽ�Ʈ �ۼ� �� Ȱ��ȭ

            playerMove.moveSpeed = 0;
            SceneManager.LoadScene("2_Crossroad");
            //enabled = false;

            //gameObject.SetActive(false);


        }
    }
}
