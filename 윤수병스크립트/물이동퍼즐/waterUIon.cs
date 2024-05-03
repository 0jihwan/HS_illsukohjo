using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class waterUIon : MonoBehaviour
{
    public GameObject WaterUI;
    public bool WUI = false;
    public GameObject cam;
    public GameObject player;
    public bool Wsolve = false;
    // Start is called before the first frame update
    void Start()
    {
        WaterUI.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(WUI==false)
        {
            GetComponent<watermove>().state = watermove.wstate.S053;
            GetComponent<watermove>().w31.gameObject.SetActive(false);
            GetComponent<watermove>().w32.gameObject.SetActive(false);
            GetComponent<watermove>().w33.gameObject.SetActive(true);
            GetComponent<watermove>().w51.gameObject.SetActive(false);
            GetComponent<watermove>().w52.gameObject.SetActive(false);
            GetComponent<watermove>().w53.gameObject.SetActive(false);
            GetComponent<watermove>().w54.gameObject.SetActive(false);
            GetComponent<watermove>().w55.gameObject.SetActive(true);
            GetComponent<watermove>().w81.gameObject.SetActive(false);
            GetComponent<watermove>().w82.gameObject.SetActive(false);
            GetComponent<watermove>().w83.gameObject.SetActive(false);
            GetComponent<watermove>().w84.gameObject.SetActive(false);
            GetComponent<watermove>().w85.gameObject.SetActive(false);
            GetComponent<watermove>().w86.gameObject.SetActive(false);
            GetComponent<watermove>().w87.gameObject.SetActive(false);
            GetComponent<watermove>().w88.gameObject.SetActive(false);

        }
        if(Wsolve == true)
        {
            Invoke("WUIOFF", 0f);
        }
    }
    public void WUION()
    {
        WaterUI.gameObject.SetActive(true);
        WUI = true;
        cam.GetComponent<CameraMove>().test = true;
        player.GetComponent<PlayerMove>().WUION = true;
    }
    public void WUIOFF()
    {
        WaterUI.gameObject.SetActive(false);
        WUI = false;
        cam.GetComponent<CameraMove>().test = false;
        player.GetComponent<PlayerMove>().WUION = false;
    }
}
