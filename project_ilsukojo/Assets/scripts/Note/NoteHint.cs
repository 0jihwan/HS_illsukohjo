using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteHint : MonoBehaviour
{
    public GameObject NHintUI;
    public bool NHUION = false;
    public GameObject cam;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        NHintUI.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void NHintUION()
    {
        NHintUI.gameObject.SetActive(true);
        cam.GetComponent<CameraMove>().ANYUION = true;
        player.GetComponent<YSBPlyaerMove>().NHintUION = true;
        NHUION = true;
    }
    public void NHintUIOFF()
    {
        NHintUI.gameObject.SetActive(false);
        cam.GetComponent<CameraMove>().ANYUION = false;
        player.GetComponent<YSBPlyaerMove>().NHintUION = false;
        NHUION = false;
    }
}
