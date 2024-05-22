using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassWordUION : MonoBehaviour
{
    public GameObject PassWordUI;
    public bool PWUION = false;
    public GameObject cam;
    public GameObject player;
    public bool PassWordSolve = false;

    public GameObject Door;
    // Start is called before the first frame update
    void Start()
    {
        PassWordUI.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(PassWordSolve == true)
        {
            //마지막 비밀번호 성공시
            Destroy(Door);
        }
    }
    public void PaUION()
    {
        PassWordUI.gameObject.SetActive(true);
        PWUION = true;
        cam.GetComponent<CameraMove>().ANYUION = true;
        player.GetComponent<YSBPlayerMove>().PassWordUION = true;

    }
    public void PaUIOFF()
    {
        PassWordUI.gameObject.SetActive(false);
        PWUION = false;
        cam.GetComponent<CameraMove>().ANYUION = false;
        player.GetComponent<YSBPlayerMove>().PassWordUION = false;
        gameObject.GetComponent<PassWordState>().state = PassWordState.Pastate.Start;
    }
}
