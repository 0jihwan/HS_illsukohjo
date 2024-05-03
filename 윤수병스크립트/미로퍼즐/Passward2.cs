using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Passward2 : MonoBehaviour
{
    public GameObject pw2;
    public float b = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PWRotate2()
    {
        pw2.transform.Rotate(0, 36, 0);
        b = b + 1;
        if (b > 9)
        {
            b = 0;
        }
    }
}
