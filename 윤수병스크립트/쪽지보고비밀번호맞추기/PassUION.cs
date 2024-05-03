using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassUION : MonoBehaviour
{
    public GameObject PassUI;
    public bool PaUI = false;
    public GameObject cam;
    public GameObject player;
    public bool Pasolve = false;
    // Start is called before the first frame update
    void Start()
    {
        PassUI.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PaUION()
    {
        PassUI.gameObject.SetActive(true);
        PaUI = true;
        cam.GetComponent<CameraMove>().test = true;
        player.GetComponent<PlayerMove>().PaUION = true;
        
    }
    public void PaUIOFF()
    {
        PassUI.gameObject.SetActive(false);
        PaUI = false;
        cam.GetComponent<CameraMove>().test = false;
        player.GetComponent<PlayerMove>().PaUION = false;
        gameObject.GetComponent<PassState>().state = PassState.Pastate.Start;
    }
}
