using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
// Room2로 넘엉가는 코드
public class GoR2 : MonoBehaviour
{
    private string sceneName = "Crossroad";
    public Transform player;

    public bool r3Activated = false;
    void Start()
    {
        if(IsFirstEntry()) gameObject.SetActive(true);
        else if (!IsFirstEntry())
        {
            gameObject.SetActive(false);
            //ClearPlayerPrefs();
            r3Activated = true;
        }

    }
    void Update()
    {
        Debug.Log(IsFirstEntry());
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("");
            //R1Q2TextBox.Instance.PlayText();  // 텍스트 작성 시 활성화
            //gameObject.SetActive(false);
            //Destroy(gameObject);
            SavePlayerPosition();
            SceneManager.LoadScene("3_Room2");
            //enabled = false;
        }
    }
    private bool IsFirstEntry()
    {
        return !PlayerPrefs.HasKey(sceneName + "_firstEntry") || PlayerPrefs.GetInt(sceneName + "_firstEntry") == 0;
    }

    public void SavePlayerPosition()
    {
        PlayerPrefs.SetFloat(sceneName + "_x", player.position.x);
        PlayerPrefs.SetFloat(sceneName + "_y", player.position.y);
        PlayerPrefs.SetFloat(sceneName + "_z", player.position.z);
        PlayerPrefs.Save();
    }
    public void ClearPlayerPrefs()
    {
        PlayerPrefs.DeleteKey(sceneName + "_x");
        PlayerPrefs.DeleteKey(sceneName + "_y");
        PlayerPrefs.DeleteKey(sceneName + "_z");
        //PlayerPrefs.DeleteKey(sceneName + "_firstEntry");
        PlayerPrefs.Save();
    }
}
