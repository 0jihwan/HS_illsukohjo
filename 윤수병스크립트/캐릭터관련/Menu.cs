using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public float Scale = 0f;
    public bool ON = false;
    public Image ui;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Resume()
    {
       // ui.gameObject.SetActive(false);
        //Scale = 1.0f;
       // ON = false;
        
        
    }

    public void Quit()
    {
        Application.Quit();
    }
}
