using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cshBtnManager : MonoBehaviour
{
    float timer;
    int waitingTime;
    bool isButtonPressed;

    void Start()
    {
        waitingTime = 4;
        isButtonPressed = false;
    }

    private void Update()
    {
        if (isButtonPressed)
        {
            timer += Time.deltaTime;
            if (timer > waitingTime)
            {
                SceneManager.LoadScene("FirstRoomSampleScene");
            }
        }
    }
    public void BtnStart()
    {
        if (!isButtonPressed)
        {
            isButtonPressed = true;
            timer = 0f;
        }
    }
    public void BtnQuit()
    {
        Application.Quit();
    }
}
