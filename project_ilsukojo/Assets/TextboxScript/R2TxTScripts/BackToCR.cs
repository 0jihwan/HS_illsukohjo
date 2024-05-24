using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToCR : MonoBehaviour
{
    [SerializeField]
    private YSBPlayerMove playerMove;

    public Transform player;
    //private string sceneName = "Crossroad";
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("충돌");
            //R1Q2TextBox.Instance.PlayText();  // 텍스트 작성 시 활성화

            playerMove.movespeed = 0;
            SceneManager.LoadScene("2_Crossroad");
            //LoadPlayerPosition();  
            //enabled = false;

            //gameObject.SetActive(false);


        }
    }
    /*
    public void LoadPlayerPosition()
    {
        if (PlayerPrefs.HasKey(sceneName + "_x"))
        {
            float x = PlayerPrefs.GetFloat(sceneName + "_x");
            float y = PlayerPrefs.GetFloat(sceneName + "_y");
            float z = PlayerPrefs.GetFloat(sceneName + "_z");
            player.position = new Vector3(x, y, z);
        }
    }
    */
}
