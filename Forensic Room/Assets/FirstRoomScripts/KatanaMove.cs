using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KatanaMove : MonoBehaviour
{
    private bool move = false;

    GameObject correctOpen;
    OpenDoor openD;

    public bool moveIt()
    {
        return move;
    }
    public void KatanaClick1()
    {
        if(move == false)
        {
            Vector3 currentPosition = gameObject.transform.position;

            currentPosition.x -= 0.25f;

            gameObject.transform.position = currentPosition;

            correctOpen = GameObject.Find("FirstRoomCorrect");
            openD = correctOpen.GetComponent<OpenDoor>();
            openD.keyNum++;

            move = true;
        }
        else
        {
            Vector3 currentPosition = gameObject.transform.position;

            currentPosition.x += 0.25f;

            gameObject.transform.position = currentPosition;

            correctOpen = GameObject.Find("FirstRoomCorrect");
            openD = correctOpen.GetComponent<OpenDoor>();
            openD.keyNum--;

            move = false;
        }
    }

    public void KatanaClick2()
    {
        if (move == false)
        {
            Vector3 currentPosition = gameObject.transform.position;

            currentPosition.z -= 0.25f;

            gameObject.transform.position = currentPosition;

            correctOpen = GameObject.Find("FirstRoomCorrect");
            openD = correctOpen.GetComponent<OpenDoor>();
            openD.keyNum++;

            move = true;
        }
        else
        {
            Vector3 currentPosition = gameObject.transform.position;

            currentPosition.z += 0.25f;

            gameObject.transform.position = currentPosition;
            
            correctOpen = GameObject.Find("FirstRoomCorrect");
            openD = correctOpen.GetComponent<OpenDoor>();
            openD.keyNum--;

            move = false;
        }
    }

    public void KatanaClick3()
    {
        if (move == false)
        {
            Vector3 currentPosition = gameObject.transform.position;

            currentPosition.x += 0.25f;

            gameObject.transform.position = currentPosition;

            correctOpen = GameObject.Find("FirstRoomCorrect");
            openD = correctOpen.GetComponent<OpenDoor>();
            openD.keyNum++;

            move = true;
        }
        else
        {
            Vector3 currentPosition = gameObject.transform.position;

            currentPosition.x -= 0.25f;

            gameObject.transform.position = currentPosition;

            correctOpen = GameObject.Find("FirstRoomCorrect");
            openD = correctOpen.GetComponent<OpenDoor>();
            openD.keyNum--;

            move = false;
        }
    }

    public void KatanaClick4()
    {
        if (move == false)
        {
            Vector3 currentPosition = gameObject.transform.position;

            currentPosition.z += 0.25f;

            gameObject.transform.position = currentPosition;

            correctOpen = GameObject.Find("FirstRoomCorrect");
            openD = correctOpen.GetComponent<OpenDoor>();
            openD.keyNum++;

            move = true;
        }
        else
        {
            Vector3 currentPosition = gameObject.transform.position;

            currentPosition.z -= 0.25f;

            gameObject.transform.position = currentPosition;

            correctOpen = GameObject.Find("FirstRoomCorrect");
            openD = correctOpen.GetComponent<OpenDoor>();
            openD.keyNum--;

            move = false;
        }
    }
}
