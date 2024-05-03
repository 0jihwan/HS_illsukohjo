using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ppbutreset : MonoBehaviour
{
    public GameObject rbut1;
    public GameObject rbut2;
    public GameObject rbut3;
    public GameObject rbut4;
    public GameObject rbut5;

    public void Pbutreset()
    {
        if (rbut1.transform.position.x == -1.53f)
        {
           rbut1.transform.Translate(new Vector3(0.04f, 0, 0));
           DoorOpen2.pa1 = 0f;
        }
        if (rbut3.transform.position.x == -1.53f)
        {
            rbut3.transform.Translate(new Vector3(0.04f, 0, 0));
            DoorOpen2.pa2 = 0f;
        }
        if (rbut5.transform.position.x == -1.53f)
        {
            rbut5.transform.Translate(new Vector3(0.04f, 0, 0));
            DoorOpen2.pa3 = 0f;
        }
        if (rbut2.transform.position.x == -1.69f)
        {
            rbut2.transform.Translate(new Vector3(-0.04f, 0, 0));
            DoorOpen2.pa4 = 0f;
        }
        if (rbut4.transform.position.x == -1.69f)
        {
            rbut4.transform.Translate(new Vector3(-0.04f, 0, 0));
            DoorOpen2.pa5 = 0f;
        }
    }
}
