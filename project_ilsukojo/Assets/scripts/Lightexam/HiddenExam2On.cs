using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenExam2On : MonoBehaviour
{
    public GameObject HiddenDoor2;
    public GameObject BinaryExam;
    public bool a, b, c, d, e = false;
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
        if ((a == true) && (b == true) && (c == true) && (d == false) && (e == false))
        {
            HiddenDoor2.SetActive(false);
            BinaryExam.SetActive(false);
        }
    }
}
