using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numberopen : MonoBehaviour
{
    public GameObject Door;
    public float npw1 = 2f;
    public float npw2 = 7f;
    public float npw3 = 5f;
    public float npw4 = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void numdooropen()
    {
        if((npw1 == GetComponent<btnchange>().numc) &&(npw2 == GetComponent<btnchange1>().numc1) &&(npw3 == GetComponent<btnchange2>().numc2) &&(npw4 == GetComponent<btnchange3>().numc3))
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
