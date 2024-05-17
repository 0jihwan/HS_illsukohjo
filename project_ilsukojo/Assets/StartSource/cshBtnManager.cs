using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cshBtnManager : MonoBehaviour
{
    float timer;
    int waitingTime = 2;
    public void BtnStart()
    {
        timer += Time.deltaTime;
        if (timer > waitingTime)
        {
            SceneManager.LoadScene("FirstRoomSampleScene");
        }
    }
    public void BtnQuit()
    {
        Application.Quit();
    }
}
