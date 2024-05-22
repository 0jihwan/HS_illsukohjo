using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CRCameraSwap : MonoBehaviour
{

    public GameObject mainPlayer;
    public GameObject aim;


    public Camera subCamera;

    public bool isClicked = false;

    public void CROnMainPlayer()
    {

        subCamera.enabled = false;

        mainPlayer.SetActive(true);
        aim.SetActive(true);

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        isClicked = true;
    }

    public void CROnSubCamera()
    {
        mainPlayer.SetActive(false);
        aim.SetActive(false);

        subCamera.enabled = true;

        //Cursor.visible = true;
        //Cursor.lockState = CursorLockMode.Confined;
    }

}