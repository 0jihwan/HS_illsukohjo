using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshExitClue : MonoBehaviour
{
    public GameObject clue1;
    public GameObject clue2;
    public GameObject clue3;   
    public GameObject clue4;

    // Update is called once per frame
    void Update()
    {
        if(exam6open.is_puz1_solved == true)
        {
            clue1.SetActive(true);
        }
        if(quiz2open.is_puz2_solved == true)//has not been assigned
        {
            clue2.SetActive(true);
        }
        if(quiz3open.is_puz3_solved == true)
        {
            clue3.SetActive(true);
        }

        clue4.SetActive(true);
    }
}
