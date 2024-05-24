using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private RotatePlayer rotatePlayer;
    private PlayerMove movement;
    public Camera subcam;

    GameObject selcetObj;
    TiltPlayerController tpc;
    CameraSwap cSwap;
    KatanaMove kMove;

    public Camera cam;

    private void Awake()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        rotatePlayer = GetComponent<RotatePlayer>();
        movement = GetComponent<PlayerMove>();
    }

    private void Start()
    {
        subcam.enabled = false;
    }

    private void Update()
    {
        UpdateRotate();
        UpdateMove();

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 8))
            {
                if(hit.transform.gameObject.tag == "TiltBtn1")
                {
                    selcetObj = GameObject.Find("TiltLeft");
                    tpc = selcetObj.GetComponent<TiltPlayerController>();
                    tpc.Select();
                }
                if (hit.transform.gameObject.tag == "TiltBtn2")
                {
                    selcetObj = GameObject.Find("TiltUp");
                    tpc = selcetObj.GetComponent<TiltPlayerController>();
                    tpc.Select();
                }
                if (hit.transform.gameObject.tag == "TiltBtn3")
                {
                    selcetObj = GameObject.Find("TiltDown");
                    tpc = selcetObj.GetComponent<TiltPlayerController>();
                    tpc.Select();
                }
                if (hit.transform.gameObject.tag == "TiltBtn4")
                {
                    selcetObj = GameObject.Find("TiltRight");
                    tpc = selcetObj.GetComponent<TiltPlayerController>();
                    tpc.Select();
                }
                if (hit.transform.gameObject.tag == "TiltBtn5")
                {
                    selcetObj = GameObject.Find("TiltRe");
                    tpc = selcetObj.GetComponent<TiltPlayerController>();
                    tpc.Select();
                }
                if(hit.transform.gameObject.tag == "NemoLogicPlaque")
                {
                    selcetObj = GameObject.Find("Plaque");
                    cSwap = selcetObj.GetComponent<CameraSwap>();
                    cSwap.OnSubCamera();
                }
                if(hit.transform.gameObject.tag == "Katana")
                {
                    selcetObj = hit.transform.gameObject;
                    kMove = selcetObj.GetComponent<KatanaMove>();
                    kMove.KatanaClick1();

                }
                if (hit.transform.gameObject.tag == "Katana2")
                {
                    selcetObj = hit.transform.gameObject;
                    kMove = selcetObj.GetComponent<KatanaMove>();
                    kMove.KatanaClick2();

                }
                if (hit.transform.gameObject.tag == "Katana3")
                {
                    selcetObj = hit.transform.gameObject;
                    kMove = selcetObj.GetComponent<KatanaMove>();
                    kMove.KatanaClick3();

                }
                if (hit.transform.gameObject.tag == "Katana4")
                {
                    selcetObj = hit.transform.gameObject;
                    kMove = selcetObj.GetComponent<KatanaMove>();
                    kMove.KatanaClick4();

                }
                //Debug.Log(hit.transform.gameObject);
            }
        }
    }

    private void UpdateRotate()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        rotatePlayer.UpdateRotate(mouseX, mouseY);
    }

    private void UpdateMove()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        movement.MoveTo(new Vector3(x, 0, z));
        if (Input.GetKey(KeyCode.LeftShift))
        {
            movement.MoveTo(new Vector3(10.0f * x, 0, 10.0f * z));
        }
    }
    
}
