using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//CrossRoad 시작 코드
public class CRstartTrigger : MonoBehaviour
{
    private string sceneName = "Crossroad";
    public Transform player;

    float timer;
    int startTime = 2;
    //private GameObject player;
    [SerializeField]
    private PlayerMove playerMove;
    void Start()
    {
        PlayerPrefs.DeleteAll();
        //ClearPlayerPrefs();
        LoadPlayerPosition();
        if (IsFirstEntry())
        {
            ExecuteFirstEntryCode();
            //SetFirstEntryFlag();
            timer = 0f; //
            //ClearPlayerPrefs();
        }
        //player = GameObject.FindWithTag("Player");
        
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        timer += Time.deltaTime;
        //Debug.Log("시간지나는중..");
        if (timer > startTime && IsFirstEntry())
        {
            SetFirstEntryFlag();
            //player.SetActive(false);    // 카메라고정을 위해 플레이어비활성화
            //Debug.Log("Event triggered!");
            CRstartTextBox.Instance.PlayText();
            playerMove.moveSpeed = 0;
            enabled = false;    //Update 루프 중단
        }
    }
    private bool IsFirstEntry()
    {
        return !PlayerPrefs.HasKey(sceneName + "_firstEntry") || PlayerPrefs.GetInt(sceneName + "_firstEntry") == 0;
    }

    private void SetFirstEntryFlag()
    {
        PlayerPrefs.SetInt(sceneName + "_firstEntry", 1);
        PlayerPrefs.Save();
    }
    private void ExecuteFirstEntryCode()
    {
        // 처음 씬에 들어왔을 때 실행할 코드


        Debug.Log("첫 번째 진입 - 특정 코드 실행");
    }


    //플레이어 위치 기억했다가 load
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
    public void ClearPlayerPrefs()
    {
        PlayerPrefs.DeleteKey(sceneName + "_x");
        PlayerPrefs.DeleteKey(sceneName + "_y");
        PlayerPrefs.DeleteKey(sceneName + "_z");
        //PlayerPrefs.DeleteKey(sceneName + "_firstEntry");
        PlayerPrefs.Save();
    }
}
