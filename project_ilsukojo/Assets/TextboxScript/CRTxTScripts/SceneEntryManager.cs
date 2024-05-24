using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneEntryManager : MonoBehaviour
{
    private string sceneName = "Crossroad";
    void Start()
    {
        //PlayerPrefs.DeleteAll();
        if (IsFirstEntry())
        {
            PlayerPrefs.DeleteAll();
        }
        else gameObject.SetActive(false);
    }

    private bool IsFirstEntry()
    {
        return !PlayerPrefs.HasKey(sceneName + "_firstEntry") || PlayerPrefs.GetInt(sceneName + "_firstEntry") == 0;
    }
}
