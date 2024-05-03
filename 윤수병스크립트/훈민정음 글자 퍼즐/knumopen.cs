using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knumopen : MonoBehaviour
{
    public GameObject Door;
    public float kpw1 = 2f;
    public float kpw2 = 8f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void kopen()
    {
        if((kpw1 == GetComponent<knumchange1>().knumc)&&(kpw2 == GetComponent<knumchange2>().knumc1))
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
