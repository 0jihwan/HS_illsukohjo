using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen2 : MonoBehaviour
{
    public GameObject Door2;
    public static float pa1 = 0f;
    public static float pa2 = 0f;
    public static float pa3 = 0f;
    public static float pa4 = 0f;
    public static float pa5 = 0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Dooropen2()
    {
        if ((pa1 == 1f) && (pa2 == 1f) && (pa3 == 1f) && (pa4 == 1f) && (pa5 == 1f))
        {
            Door2.transform.position = new Vector3(-0.627f, 1.2f, 9.05f);
            Door2.transform.Rotate(0, 90, 0);
        }
        else
        {
            Door2.transform.position = new Vector3(0f, 1.2f, 8.6f);
            Door2.transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
    }
}
   
