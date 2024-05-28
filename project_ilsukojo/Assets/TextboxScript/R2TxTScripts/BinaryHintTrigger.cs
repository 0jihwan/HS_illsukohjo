using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinaryHintTrigger : MonoBehaviour
{
    public BinaryHint binaryhint;

    [SerializeField]
    private YSBPlayerMove playerMove;
    void Start()
    {
        //Cursor.visible = false;
        //Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if(binaryhint.bhuiononce && !binaryhint.BHUION)
        {
            BinaryHintText.Instance.PlayText();
            playerMove.movespeed = 0;
            enabled = false;    //Update 루프 중단
        }
    }
}
