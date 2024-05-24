using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//CrossRoad ���� �ڵ�
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
        //Debug.Log("�ð���������..");
        if (timer > startTime && IsFirstEntry())
        {
            SetFirstEntryFlag();
            //player.SetActive(false);    // ī�޶������ ���� �÷��̾��Ȱ��ȭ
            //Debug.Log("Event triggered!");
            CRstartTextBox.Instance.PlayText();
            playerMove.moveSpeed = 0;
            enabled = false;    //Update ���� �ߴ�
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
        // ó�� ���� ������ �� ������ �ڵ�


        Debug.Log("ù ��° ���� - Ư�� �ڵ� ����");
    }


    //�÷��̾� ��ġ ����ߴٰ� load
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
