using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static SoundState;

public class UDstate : MonoBehaviour
{
    public float U = 0f;
    public float D = 0f;
    public float R = 0f;
    public float L = 0f;
    public GameObject Door;
    public GameObject UDEXAM;
    public GameObject player;
    public GameObject cam;
    public enum Ustate
    {
        Start,
        s1,
        s2,
        s3,
        s4,
        s5,
        s6,
        s7,
        s8,
        s9,
        sfinal
    }
    public Ustate state;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (U == 1f)
        {
            Invoke("Up", 0f);
            U = 0f;
        }
        if (D == 1f)
        {
            Invoke("Down", 0f);
            D = 0f;
        }
        if (R == 1f)
        {
            Invoke("Right", 0f);
            R = 0f;
        }
        if (L == 1f)
        {
            Invoke("Left", 0f);
            L = 0f;
        }
    }

    public void Up()
    {
        if (state == Ustate.s2)
        {
            state = Ustate.s3;
        }
        else if (state == Ustate.s4)
        {
            state = Ustate.s5;
        }
        else if (state == Ustate.sfinal)
        {
            Door.transform.position = new Vector3(0f, 1.2f, 8.6f);
            Door.transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
        else
        {
            state = Ustate.Start;
        }
    }
    public void Down()
    {
        if (state == Ustate.s3)
        {
            state = Ustate.s4;
        }
        else if (state == Ustate.s6)
        {
            state = Ustate.s7;
        }
        else if (state == Ustate.s7)
        {
            state = Ustate.s8;
        }
        else if (state == Ustate.s9)
        {
            state = Ustate.sfinal;
            Door.transform.position = new Vector3(-0.627f, 1.2f, 9.05f);
            Door.transform.Rotate(0, 90, 0);
            UDEXAM.gameObject.SetActive(false);
            cam.GetComponent<CameraMove>().test = false;
            player.GetComponent<PlayerMove>().UDON = false;
            
        }
        else if (state == Ustate.sfinal)
        {
            Door.transform.position = new Vector3(0f, 1.2f, 8.6f);
            Door.transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
        else
        {
            state = Ustate.Start;
        }
    }
    public void Right()
    {
        if (state == Ustate.s1)
        {
            state = Ustate.s2;
        }
        else if (state == Ustate.s5)
        {
            state = Ustate.s6;
        }
        else if (state == Ustate.s8)
        {
            state = Ustate.s9;
        }
        else if (state == Ustate.sfinal)
        {
            Door.transform.position = new Vector3(0f, 1.2f, 8.6f);
            Door.transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
        else
        {
            state = Ustate.Start;
        }

    }
    public void Left()
    {
        if (state == Ustate.Start)
        {
            state = Ustate.s1;
        }
        else if (state == Ustate.sfinal)
        {
            Door.transform.position = new Vector3(0f, 1.2f, 8.6f);
            Door.transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
        else
        {
            state = Ustate.Start;
        }
    }
}
