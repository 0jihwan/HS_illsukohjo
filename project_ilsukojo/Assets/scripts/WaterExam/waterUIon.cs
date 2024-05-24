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
    //문제 풀었을때
    public bool Wsolve = false;

    public GameObject LHint,Lbtn1;

    private float a = 0;
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
            if (a == 0)
            {
                Invoke("WUIOFF", 0f);
                LHint.gameObject.SetActive(true);
                Lbtn1.gameObject.SetActive(true);
                a++;
            }
        }
    }
    public void WUION()
    {
        WaterUI.gameObject.SetActive(true);
        WUI = true;
        cam.GetComponent<CameraMove>().ANYUION = true;
        player.GetComponent<YSBPlayerMove>().WaterUION = true;
    }
    public void WUIOFF()
    {
        WaterUI.gameObject.SetActive(false);
        WUI = false;
        cam.GetComponent<CameraMove>().ANYUION = false;
        player.GetComponent<YSBPlayerMove>().WaterUION = false;
    }

    public void Wreset()
    {
        WUI = false;
        Invoke("WUIBON", 0.1f);
    }
    public void WUIBON()
    {
        WUI = true;
    }
}
