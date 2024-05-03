using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Ppbut1 : MonoBehaviour
{
    public GameObject but1;
    public GameObject but2;
    public GameObject but3;
    

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Pbut1()
    {

        if (but1.transform.position.x == -1.49f)
        {
            but1.transform.Translate(new Vector3(-0.04f,0, 0));            
            DoorOpen2.pa1 = 1f;
        }
        else if (but1.transform.position.x == -1.53f)
        {
            but1.transform.Translate(new Vector3(0.04f, 0, 0));          
            DoorOpen2.pa1 = 0f;
        }
        if (but2.transform.position.x == -1.49f)
        {
            but2.transform.Translate(new Vector3(-0.04f, 0, 0));           
            DoorOpen2.pa3 = 1f;
        }
        else if (but2.transform.position.x == -1.53f)
        {
            but2.transform.Translate(new Vector3(0.04f, 0, 0));
            DoorOpen2.pa3 = 0f;
        }
        if (but3.transform.position.x == -1.49f)
        {
            but3.transform.Translate(new Vector3(-0.04f, 0, 0));
            DoorOpen2.pa5 = 1f;
        }
        else if (but3.transform.position.x == -1.53f)
        {
            but3.transform.Translate(new Vector3(0.04f, 0, 0));         
            DoorOpen2.pa5 = 0f;
        }

        /*if (but3.transform.position.x == -1.73f)
        {
            but1.transform.Translate(new Vector3(0.04f, 0, 0));
        }
        else if (but3.transform.position.x == -1.69f)
        {
            but1.transform.Translate(new Vector3(-0.04f, 0, 0));
        }*/


    }
}
