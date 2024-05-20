using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastHintUION : MonoBehaviour
{
    public GameObject LastHintUI;
    public bool LHintON = false;
    public GameObject cam;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        LastHintUI.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void LHintUION()
    {
        LastHintUI.gameObject.SetActive(true);
        cam.GetComponent<CameraMove>().ANYUION = true;
        player.GetComponent<YSBPlyaerMove>().LHintUION = true;
        LHintON = true;
    }
    public void LHintUIOFF()
    {
        LastHintUI.gameObject.SetActive(false);
        cam.GetComponent<CameraMove>().ANYUION = false;
        player.GetComponent<YSBPlyaerMove>().LHintUION = false;
        LHintON = false;
    }
}
