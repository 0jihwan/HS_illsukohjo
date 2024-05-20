using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenExam1On : MonoBehaviour
{
    public GameObject HiddenDoor1;
    public GameObject WaterExam;
    public bool a,b,c,d,e = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        a = gameObject.GetComponent<LightOnOff>().light1;
        b = gameObject.GetComponent<LightOnOff>().light2;
        c = gameObject.GetComponent<LightOnOff>().light3;
        d = gameObject.GetComponent<LightOnOff>().light4;
        e = gameObject.GetComponent<LightOnOff>().light5;
    }
    public void Hidden1Check()
    {
        if((a==true)&&(b==false)&&(c == false) &&(d == false) &&(e == false))
        {
            HiddenDoor1.SetActive(false);
            WaterExam.SetActive(false);
        }
    }
}
