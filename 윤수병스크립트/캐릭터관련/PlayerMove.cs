using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    public Transform cameraTransform;
    public CharacterController characterController;
    [SerializeField]
    private float movespeed = 5f;
    [SerializeField]
    private float jumpspeed = 10f;
    [SerializeField]
    private float gravity = -20f;
    [SerializeField]
    private float yVelocity = 0;
    public Image ui;
    public bool UION,WUION,PaUION = false;
    public float timeScale = 1.0f;
    public GameObject WUI;
    public GameObject Water;
    public GameObject PaUI;
    public GameObject PassWord;

    //public Transform[] T;


    // Start is called before the first frame update
    void Start()
    {
        //T = gameObject.GetComponentsInChildren<Transform>();
        ui.gameObject.SetActive(false);
        //업다운퀴즈
        
        UDEXAM.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        Time.timeScale = timeScale;
        //timeScale = GetComponent<Menu>().Scale = timeScale;
        //UION = GetComponent<Menu>().ON;
        Cursor.visible = true;
        if (UION == false)
        {
            Cursor.lockState = CursorLockMode.Confined;
        }
        if (UION == true)
        {
            Cursor.lockState = CursorLockMode.None;
        }
        if((!UDON)&&(!WUION)) { 
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");

            Vector3 moveDirection = new Vector3(h, 0 ,v);
            moveDirection = cameraTransform.TransformDirection(moveDirection);
            moveDirection *= movespeed;
            if (characterController.isGrounded)
            {
                yVelocity = 0;
                if (Input.GetKeyUp(KeyCode.Space))
                {
                    yVelocity = jumpspeed;
                }
            }
            yVelocity += (gravity * Time.deltaTime);
            moveDirection.y = yVelocity;
            characterController.Move(moveDirection* Time.deltaTime);
        }


        if (Input.GetKeyDown("escape"))
        {
           if((UION == false)&&(UDON == false)&&(WUION == false)&&(PaUION==false))
           {
                ui.gameObject.SetActive(true);
                timeScale = 0f;
                UION = true;
           }
           else if(UION ==  true)
           {
                ui.gameObject.SetActive(false);
                timeScale = 1.0f;
                UION = false;
                
           }
           else if(UDON == true)
            {
                
                UDEXAM.gameObject.SetActive(false);
                gameObject.GetComponentInChildren<CameraMove>().test = false;
                UDON = false;
            }
            else if (WUION == true)
            {

                WUI.gameObject.SetActive(false);
                gameObject.GetComponentInChildren<CameraMove>().test = false;
                WUION = false;
                Water.GetComponent<waterUIon>().WUI = false;
            }
            else if (PaUION == true)
            {

                PaUI.gameObject.SetActive(false);
                gameObject.GetComponentInChildren<CameraMove>().test = false;
                PaUION = false;
                PassWord.GetComponent<PassUION>().PaUI = false;
                PassWord.GetComponent<PassState>().state = PassState.Pastate.Start;
            }

        }
        //Application.Quit();
        //업다운
        if ((UDON == false)&& (WUION == false) && (PaUION == false))
        {
            Cursor.lockState = CursorLockMode.Confined;
        }
        if ((UDON == true)|| (WUION == true) || (PaUION == true))
        {
            Cursor.lockState = CursorLockMode.None;
        }

        //GetComponent<CameraMove>().test = UDON;
        //GetComponent<CameraMove>().t = on;
    }

    public void resume()
    {
        ui.gameObject.SetActive(false);
        timeScale = 1.0f;
        UION = false;
    }

    //업다운퀴즈
    public Image ud;
    public Image udu;
    public Image udd;
    public Image udr;
    public Image udl;
    public Image udback;
    public Image udexit;
    public GameObject UDEXAM;
    //public GameObject cam;
    public bool UDON = false;
    public float on = 0f; 
    
    public void UDOn()
    {
        UDEXAM.gameObject.SetActive(true);       
        UDON = true;
        gameObject.GetComponentInChildren<CameraMove>().test = true;

    }

    public void UDOFF()
    {       
        UDEXAM.gameObject.SetActive(false);
        gameObject.GetComponentInChildren<CameraMove>().test = false;
        UDON = false;
    }
    IEnumerator UDC()
    {
        yield return new WaitForSecondsRealtime(0.1f);
        ud.gameObject.SetActive(true);
        udr.gameObject.SetActive(false);
        udl.gameObject.SetActive(false);
        udu.gameObject.SetActive(false);
        udd.gameObject.SetActive(false);
    }
    public void UDR()
    {
        ud.gameObject.SetActive(false);
        udr.gameObject.SetActive(true);
        GetComponent<UDstate>().R = 1f;
        StartCoroutine("UDC");
    }
    public void UDL()
    {
        ud.gameObject.SetActive(false);
        udl.gameObject.SetActive(true);
        GetComponent<UDstate>().L = 1f;
        StartCoroutine("UDC");
    }
    public void UDU()
    {
        ud.gameObject.SetActive(false);
        udu.gameObject.SetActive(true);
        GetComponent<UDstate>().U = 1f;
        StartCoroutine("UDC");

    }
    public void UDD()
    {
        ud.gameObject.SetActive(false);
        udd.gameObject.SetActive(true);
       GetComponent<UDstate>().D = 1f;
        StartCoroutine("UDC");
    }
    
    
}
