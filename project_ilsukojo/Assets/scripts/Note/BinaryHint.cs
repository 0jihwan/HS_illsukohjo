using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinaryHint : MonoBehaviour
{
    public GameObject BHintUI;
    public bool BHUION = false;
    public GameObject cam;
    public GameObject player;

    public bool bhuiononce = false;
    // Start is called before the first frame update
    void Start()
    {
        BHintUI.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BHintUION()
    {
        BHintUI.gameObject.SetActive(true);
        cam.GetComponent<CameraMove>().ANYUION = true;
        player.GetComponent<YSBPlayerMove>().BHintUION = true;
        BHUION = true;
        bhuiononce = true;
    }
    public void BHintUIOFF()
    {
        BHintUI.gameObject.SetActive(false);
        cam.GetComponent<CameraMove>().ANYUION = false;
        player.GetComponent<YSBPlayerMove>().BHintUION = false;
        BHUION = false;
    }
}
