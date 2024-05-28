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
                SceneManager.LoadScene("1_Room1");
            }
        }
    }
    public void BtnStart()
    {
        if (!isButtonPressed)
        {
            PlayerPrefs.DeleteAll();//수집품 데이터 초기화
            isButtonPressed = true;
            timer = 0f;
        }
    }
    public void BtnQuit()
    {
        Application.Quit();
    }
}
