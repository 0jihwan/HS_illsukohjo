using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UpDownState : MonoBehaviour
{
    public Image UDup;
    public Image UDdown;
    public Image UDright;
    public Image UDleft;
    public Image UDcenter;

    public float U = 0f;
    public float D = 0f;
    public float R = 0f;
    public float L = 0f;

    public GameObject UDUI;
    public GameObject player;
    public GameObject cam;
    //문제 풀었을때
    public bool UDsolve=false;
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

    public GameObject LHint3, Lbtn3;
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

        if(UDsolve==true)
        {
            LHint3.gameObject.SetActive(true);
            Lbtn3.gameObject.SetActive(true);
        }
    }
    //이미지 움직이기
    IEnumerator UDC()
    {
        yield return new WaitForSecondsRealtime(0.1f);
        UDcenter.gameObject.SetActive(true);
        UDright.gameObject.SetActive(false);
        UDleft.gameObject.SetActive(false);
        UDup.gameObject.SetActive(false);
        UDdown.gameObject.SetActive(false);
    }
    public void UDR()
    {
        UDcenter.gameObject.SetActive(false);
        UDright.gameObject.SetActive(true);
        R = 1f;
        StartCoroutine("UDC");
    }
    public void UDL()
    {
        UDcenter.gameObject.SetActive(false);
        UDleft.gameObject.SetActive(true);
        L = 1f;
        StartCoroutine("UDC");
    }
    public void UDU()
    {
        UDcenter.gameObject.SetActive(false);
        UDup.gameObject.SetActive(true);
        U = 1f;
        StartCoroutine("UDC");

    }
    public void UDD()
    {
        UDcenter.gameObject.SetActive(false);
        UDdown.gameObject.SetActive(true);
        D = 1f;
        StartCoroutine("UDC");
    }

    //상태 전이 함수
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
            //UDUI.gameObject.SetActive(false);
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
            UDsolve = true;
            UDUI.gameObject.SetActive(false);
            cam.GetComponent<CameraMove>().ANYUION = false;
            player.GetComponent<YSBPlyaerMove>().UpDownUION = false;

        }
        else if (state == Ustate.sfinal)
        {
            
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
            
        }
        else
        {
            state = Ustate.Start;
        }
    }
}
