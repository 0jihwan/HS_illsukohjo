using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenma : MonoBehaviour
{
    public GameObject Door;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void dopen()
    {
        Door.transform.position = new Vector3(-0.627f, 1.2f, 9.05f);
        Door.transform.Rotate(0, 90, 0);
    }
}
