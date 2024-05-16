using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject puzzle1;
    public GameObject puzzle2;
    public GameObject puzzle3;
    public GameObject puzzle4;

    public GameObject blood1;
    public GameObject blood2;
    public GameObject blood3;
    public GameObject blood4;

    private bool key1 = false;
    private bool key2 = false;
    private bool key3 = false;
    private bool key4 = false;

    private bool open = false;

    public int keyNum = 0;

    public GameObject door;


    public void keyInsert1()
    {
        
        key1 = true;

    }

    public void keyInsert2()
    {
        key2 = true;

    }

    public void keyInsert3()
    {
        key3 = true;

    }

    public void keyInsert4()
    {
        key4 = true;

    }

    public void keyOut1()
    {
        key1 = false;

    }

    public void keyOut2()
    {
        key2 = false;

    }

    public void keyOut3()
    {
        key3 = false;

    }

    public void keyOut4()
    {
        key4 = false;

    }
    // Update is called once per frame
    void Update()
    {
        if (open == false)
        {
            if (key1 && key2 && key3 && key4 && keyNum == 4)
            {
                Vector3 currentPosition1 = puzzle1.transform.position;
                Vector3 currentPosition2 = puzzle2.transform.position;
                Vector3 currentPosition3 = puzzle3.transform.position;
                Vector3 currentPosition4 = puzzle4.transform.position;

                currentPosition1.y -= 0.18f;
                currentPosition2.y -= 0.21f;
                currentPosition3.y -= 0.18f;
                currentPosition4.y -= 0.18f;

                puzzle1.transform.position = currentPosition1;
                puzzle2.transform.position = currentPosition2;
                puzzle3.transform.position = currentPosition3;
                puzzle4.transform.position = currentPosition4;

                door.transform.rotation = Quaternion.Euler(-90f, -90f, 0);

                blood1.SetActive(true);
                blood2.SetActive(true);
                blood3.SetActive(true);
                blood4.SetActive(true);


                open = true;

            }
        }
    }
}
