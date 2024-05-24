using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class YSBPlayerMove : MonoBehaviour
{
    public Transform cameraTransform;
    public CharacterController characterController;
    [SerializeField]
    public float movespeed = 5f;
    //[SerializeField]
    //private float jumpspeed = 0f;
    [SerializeField]
    private float gravity = 0f;
    [SerializeField]
    private float yVelocity = 0;
    //UI bool��
    public bool WaterUION=false;
    public bool BHintUION = false;
    public bool UpDownUION = false;
    public bool NHintUION = false;
    public bool LHintUION = false;
    public bool PassWordUION = false;

    //Ű�� �ҷ��� UI ��
    public GameObject WUI;
    public GameObject BHintUI;
    public GameObject NHintUI;
    public GameObject UpDownUI;
    public GameObject LHintUI;
    public GameObject PassWordUI;

    //�ʿ��ѽ�ũ��Ʈ�� �ִ� ������Ʈ
    public GameObject Water;
    public GameObject Hint;
    public GameObject UpDown;
    public GameObject PassWord;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Cursor.visible = true;//���콺 ������ ���̱�
        Cursor.lockState = CursorLockMode.Confined;//���콺 ȭ��ȿ� ���α�
        //Cursor.lockState = CursorLockMode.None;//���콺 ȭ��� ����
        //Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        if ((!WaterUION)&&(!BHintUION)&&(!UpDownUION)&&(!NHintUION)&&(!LHintUION)&&(!PassWordUION)) {
            //�÷��̾� ������
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");

            Vector3 moveDirection = new Vector3(h, 0, v);
            moveDirection = cameraTransform.TransformDirection(moveDirection);
            moveDirection *= movespeed;
            if (characterController.isGrounded)
            {
                yVelocity = 0;
                /*
                if (Input.GetKeyUp(KeyCode.Space))
                {
                    yVelocity = jumpspeed;
                }
                */
            }
            yVelocity += (gravity * Time.deltaTime);
            moveDirection.y = yVelocity;
            characterController.Move(moveDirection * Time.deltaTime);
        }

        //escŰ ��������
        if (Input.GetKeyDown("escape"))
        {
            if (WaterUION == true)
            {

                WUI.gameObject.SetActive(false);
                gameObject.GetComponentInChildren<CameraMove>().ANYUION = false;
                WaterUION = false;
                Water.GetComponent<waterUIon>().WUI = false;
            }
            else if (BHintUION == true)
            {

                BHintUI.gameObject.SetActive(false);
                gameObject.GetComponentInChildren<CameraMove>().ANYUION = false;
                BHintUION = false;
                Hint.GetComponent<BinaryHint>().BHUION = false;
            }
            else if (UpDownUION == true)
            {

                UpDownUI.gameObject.SetActive(false);
                gameObject.GetComponentInChildren<CameraMove>().ANYUION = false;
                UpDownUION = false;
                UpDown.GetComponent<UpDownUIon>().UDUIon = false;
            }
            else if (NHintUION == true)
            {

                NHintUI.gameObject.SetActive(false);
                gameObject.GetComponentInChildren<CameraMove>().ANYUION = false;
                NHintUION = false;
                Hint.GetComponent<NoteHint>().NHUION = false;
            }
            else if (LHintUION == true)
            {

                LHintUI.gameObject.SetActive(false);
                gameObject.GetComponentInChildren<CameraMove>().ANYUION = false;
                LHintUION = false;
                Hint.GetComponent<LastHintUION>().LHintON = false;
            }
            else if (PassWordUION == true)
            {

                PassWordUI.gameObject.SetActive(false);
                gameObject.GetComponentInChildren<CameraMove>().ANYUION = false;
                PassWordUION = false;
                PassWord.GetComponent<PassWordUION>().PWUION = false;
            }
        }
    }
}
