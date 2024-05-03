using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ppbut3 : MonoBehaviour
{
    public GameObject but31;
    public GameObject but32;
    public GameObject but33;

    public void Pbut3()
    {
        if (but31.transform.position.x == -1.49f)
        {
            but31.transform.Translate(new Vector3(-0.04f, 0, 0));
            DoorOpen2.pa1 = 1f;
        }
        else if (but31.transform.position.x == -1.53f)
        {
            but31.transform.Translate(new Vector3(0.04f, 0, 0));
            DoorOpen2.pa1 = 0f;
        }
        if (but32.transform.position.x == -1.49f)
        {
            but32.transform.Translate(new Vector3(-0.04f, 0, 0));
            DoorOpen2.pa3 = 1f;
        }
        else if (but32.transform.position.x == -1.53f)
        {
            but32.transform.Translate(new Vector3(0.04f, 0, 0));
            DoorOpen2.pa3 = 0f;
        }
        if (but33.transform.position.x == -1.73f)
        {
            but33.transform.Translate(new Vector3(0.04f, 0, 0));
            DoorOpen2.pa4 = 1f;
        }
        else if (but33.transform.position.x == -1.69f)
        {
            but33.transform.Translate(new Vector3(-0.04f, 0, 0));
            DoorOpen2.pa4 = 0f;
        }
    }
}
