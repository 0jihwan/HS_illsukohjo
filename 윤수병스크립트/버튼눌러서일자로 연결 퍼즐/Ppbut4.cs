using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ppbut4 : MonoBehaviour
{
    public GameObject but41;
    public GameObject but42;
    public GameObject but43;

    public void Pbut4()
    {
        if (but41.transform.position.x == -1.49f)
        {
            but41.transform.Translate(new Vector3(-0.04f, 0, 0));
            DoorOpen2.pa1 = 1f;
        }
        else if (but41.transform.position.x == -1.53f)
        {
            but41.transform.Translate(new Vector3(0.04f, 0, 0));
            DoorOpen2.pa1 = 0f;
        }
        if (but42.transform.position.x == -1.73f)
        {
            but42.transform.Translate(new Vector3(0.04f, 0, 0));
            DoorOpen2.pa2 = 1f;
        }
        else if (but42.transform.position.x == -1.69f)
        {
            but42.transform.Translate(new Vector3(-0.04f, 0, 0));
            DoorOpen2.pa2 = 0f;
        }
        if (but43.transform.position.x == -1.73f)
        {
            but43.transform.Translate(new Vector3(0.04f, 0, 0));
            DoorOpen2.pa4 = 1f;
        }
        else if (but43.transform.position.x == -1.69f)
        {
            but43.transform.Translate(new Vector3(-0.04f, 0, 0));
            DoorOpen2.pa4 = 0f;
        }
    }
}
