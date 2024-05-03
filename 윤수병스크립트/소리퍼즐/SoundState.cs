using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;

public class SoundState : MonoBehaviour
{
    public float a, b, c  = 0f;
    public GameObject SDoor;
    
    public enum Sstate
    {
        Start,
        s1,
        s2,
        s3,
        s4,
        s5,
        s6,
        sfinal
    }
    public Sstate state;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(a==1f)
        {
            Invoke("AStart",0f);
            a = 0f;
        }
        if(b==1f)
        {
            Invoke("BStart", 0f);
            b = 0f;
        }
        if(c==1f)
        {
            Invoke("CStart", 0f);
            c = 0f;
        }
    }
    public void AStart()
    {
        if(state == Sstate.s2)
        {
            state = Sstate.s3;
        }
        else if (state == Sstate.sfinal)
        {
            SDoor.transform.position = new Vector3(0f, 1.2f, 8.6f);
            SDoor.transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
        else
        {
            state = Sstate.Start;
        }
    }
    public void BStart()
    {
        if (state == Sstate.s1)
        {
            state = Sstate.s2;
        }
        else if (state == Sstate.s3)
        {
            state = Sstate.s4;
        }
        else if (state == Sstate.sfinal)
        {
            SDoor.transform.position = new Vector3(0f, 1.2f, 8.6f);
            SDoor.transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
        else
        {
            state = Sstate.Start;
        }
    }
    public void CStart()
    {
        if(state == Sstate.Start)
        {
            state = Sstate.s1;
        }
        else if(state == Sstate.s4)
        {
            state = Sstate.s5;
        }
        else if(state == Sstate.s5)
        {
            state = Sstate.s6;
        }
        else if( state == Sstate.s6)
        {
            state = Sstate.sfinal;
            SDoor.transform.position = new Vector3(-0.627f, 1.2f, 9.05f);
            SDoor.transform.Rotate(0, 90, 0);
        }
        else if(state == Sstate.sfinal)
        {
            SDoor.transform.position = new Vector3(0f, 1.2f, 8.6f);
            SDoor.transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
        else { state = Sstate.Start; }
    }
}
