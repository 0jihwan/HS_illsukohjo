using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public GameObject Door;
    private float pw1;
    private float pw2;
    public float pwa = 2;
    public float pwb = 2;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    public void Dooropen()
    {
      pw1 = GetComponent<Passward1>().a;
        pw2 = GetComponent<Passward2>().b;
        if (pw1 == pwa)
        {
            if (pw2 == pwb)
            {
                Door.transform.position = new Vector3(-0.627f, 1.2f, 9.05f);
                Door.transform.Rotate(0, 90, 0);
            }
        }
        if (pw1 != pwa)
        {
                Door.transform.position = new Vector3(0f, 1.2f, 8.6f);
                Door.transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
        if(pw2 != pwb)
        {
            Door.transform.position = new Vector3(0f, 1.2f, 8.6f);
            Door.transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
    }
    
}
