using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownUIon : MonoBehaviour
{
    public GameObject UpDownUI;
    public bool UDUIon = false;
    public GameObject cam;
    public GameObject player;
    public bool UDsolve = false;
    // Start is called before the first frame update
    void Start()
    {
        UpDownUI.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void WUION()
    {
        UpDownUI.gameObject.SetActive(true);
        UDUIon = true;
        cam.GetComponent<CameraMove>().ANYUION = true;
        player.GetComponent<YSBPlayerMove>().UpDownUION = true;
    }
    public void WUIOFF()
    {
        UpDownUI.gameObject.SetActive(false);
        UDUIon = false;
        cam.GetComponent<CameraMove>().ANYUION = false;
        player.GetComponent<YSBPlayerMove>().UpDownUION = false;
    }
}
