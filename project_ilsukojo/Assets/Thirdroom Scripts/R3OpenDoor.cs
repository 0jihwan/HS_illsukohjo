using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class R3OpenDoor : MonoBehaviour
{
    private Animator anim;
    private bool IsAtDoor = false;

    public SC_FPSController controller;

    [SerializeField] private TextMeshProUGUI CodeText;
    string codeTextValue = "";
    public string safeCode;
    public GameObject CodePanel;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        CodeText.text = codeTextValue;
        if(codeTextValue == safeCode)
        {
            anim.SetTrigger("OpenDoor");
            CodePanel.SetActive(false);

            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            controller.canMove = true;
        }
        if(codeTextValue.Length >= 4)
        {
            codeTextValue = "";
        }
        if(Input.GetMouseButtonDown(0) && IsAtDoor == true)
        {
            CodePanel.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            controller.canMove = false;
 
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            CodePanel.SetActive(false);

            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            controller.canMove = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            IsAtDoor = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        IsAtDoor=false;
        CodePanel.SetActive(false);

        //Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = false;
        //controller.canMove = true;
    }

    public void AddDigit(string digit)
    {
        codeTextValue += digit;
    }
}


    //GetKey(KeyCode.Q)
