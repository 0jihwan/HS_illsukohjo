using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshExit : MonoBehaviour
{
    
    public static bool QuizSolved = false;
    private bool R1 = false;
    private bool R2 = false;
    private bool R3 = false;
    private bool R4 = false;
    private GameObject Door;

    // Update is called once per frame
    void Update()
    {
        // ���� 1, 2, 3, 4 Ǯ���� �� ���� if��
        if (exam6open.is_puz1_solved == true)
        {
            Debug.Log("1�� �� Ż��!");
            R1 = true;
        }
        if(quiz2open.is_puz2_solved == true)
        {
            Debug.Log("2�� �� Ż��!");
            R2 = true;
        }
        if(quiz3open.is_puz3_solved == true)
        {
            Debug.Log("3�� �� Ż��!");
            R3 = true;
        }
        R4 = true;
        if(R1 && R2 && R3 && R4)
        {
            QuizSolved = true;
        }
    }
}
