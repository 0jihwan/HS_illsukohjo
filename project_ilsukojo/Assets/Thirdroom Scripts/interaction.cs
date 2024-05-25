

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interaction : MonoBehaviour
{
    public float interactionDistance;
    public GameObject interactionText;
    public LayerMask interactionLayers;
    
    //public CharacterController playerController;

    void FixedUpdate()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit, interactionDistance, interactionLayers))
        {
            if (hit.collider.gameObject.GetComponent<letter>())
            {
                interactionText.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    //Cursor.visible = true;
                    //Cursor.lockState = CursorLockMode.None;

                    //playerController.enabled = false;
                    hit.collider.gameObject.GetComponent<letter>().openCloseLetter();

                }
            }
            else
            {
                interactionText.SetActive(false);
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
                //playerController.enabled = true;
            }
        }
        else
        {
            interactionText.SetActive(false);
        }
    }
}
