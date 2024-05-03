using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exam6open : MonoBehaviour
{
    public GameObject Door;
    public float pw1 = 0f;
    public float pw2 = 2f;
    public float pw3 = 8f;
    public float pw4 = 7f;
    public float pw5 = 4f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Open()
    {
        if ((pw1 == GetComponent<exam6change1>().numc) && (pw2 == GetComponent<exam6c2>().numc) &&(pw3 == GetComponent<exam6c3>().numc)&&(pw4 == GetComponent<exam6c4>().numc)&&(pw5 == GetComponent<exam6c5>().numc))
        {
            Door.transform.position = new Vector3(-0.627f, 1.2f, 9.05f);
            Door.transform.Rotate(0, 90, 0);
        }
        else
        {
            Door.transform.position = new Vector3(0f, 1.2f, 8.6f);
            Door.transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
    }
}
