using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyKatana2 : MonoBehaviour
{
    //private bool key = false;
    KatanaMove keyMove;

    GameObject correctKey;
    OpenDoor oDoor;

    private void Start()
    {
        keyMove = gameObject.GetComponent<KatanaMove>();
        correctKey = GameObject.Find("FirstRoomCorrect");
        oDoor = correctKey.GetComponent<OpenDoor>();
    }

    // Update is called once per frame
    void Update()
    {
        if (keyMove.moveIt())
        {
            oDoor.keyInsert2();
            //key = true;
        }

        if (keyMove.moveIt()== false)
        {
            oDoor.keyOut2();
            //key = false;
        }
        
    }
}
