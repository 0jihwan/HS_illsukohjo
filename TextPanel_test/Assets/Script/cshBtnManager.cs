using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cshBtnManager : MonoBehaviour
{
    public void BtnStart()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void BtnQuit()
    {
        Application.Quit();
    }
}
