using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ppbut2 : MonoBehaviour
{
    public GameObject but21;
    public GameObject but22;
    public GameObject but23;
    
    public void Pbut2()
    {
        if (but21.transform.position.x == -1.49f)
        {
            but21.transform.Translate(new Vector3(-0.04f, 0, 0));
            DoorOpen2.pa1 = 1f;
        }
        else if (but21.transform.position.x == -1.53f)
        {
            but21.transform.Translate(new Vector3(0.04f, 0, 0));
            DoorOpen2.pa1 = 0f;
        }
        if (but22.transform.position.x == -1.73f)
        {
            but22.transform.Translate(new Vector3(0.04f, 0, 0));
            DoorOpen2.pa4 = 1f;
        }
        else if (but22.transform.position.x == -1.69f)
        {
            but22.transform.Translate(new Vector3(-0.04f, 0, 0));
            DoorOpen2.pa4 = 0f;
        }
        if (but23.transform.position.x == -1.49f)
        {
            but23.transform.Translate(new Vector3(-0.04f, 0, 0));
            DoorOpen2.pa5 = 1f;
        }
        else if (but23.transform.position.x == -1.53f)
        {
            but23.transform.Translate(new Vector3(0.04f, 0, 0));
            DoorOpen2.pa5 = 0f;
        }
    }
}
