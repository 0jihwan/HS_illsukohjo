using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwap : MonoBehaviour
{
    public GameObject mainPlayer;
    public GameObject aim;

    public GameObject nemoLogic;
    public Camera subCamera;

    public void OnMainPlayer()
    {
        nemoLogic.SetActive(false);
        subCamera.enabled = false;

        mainPlayer.SetActive(true);
        aim.SetActive(true);

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void OnSubCamera()
    {
        mainPlayer.SetActive(false);
        aim.SetActive(false);

        subCamera.enabled = true;
        nemoLogic.SetActive(true);

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(gameObject.name == "FirstRoomSubCamera")
            {
                OnMainPlayer();
            }
        }
    }
}
