using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinaryHint : MonoBehaviour
{
    public GameObject BHintUI;
    public bool BHUION = false;
    public GameObject cam;
    public GameObject player;
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
        player.GetComponent<YSBPlyaerMove>().BHintUION = true;
        BHUION = true;
    }
    public void BHintUIOFF()
    {
        BHintUI.gameObject.SetActive(false);
        cam.GetComponent<CameraMove>().ANYUION = false;
        player.GetComponent<YSBPlyaerMove>().BHintUION = false;
        BHUION = false;
    }
}