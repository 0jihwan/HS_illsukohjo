using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Passward1 : MonoBehaviour
{
    public GameObject pw1;
    public float a = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PWRotate1()
    {
        pw1.transform.Rotate(0, 36, 0);
        a = a + 1;
        if(a > 9)
        {
            a = 0;
        }
    }
}

