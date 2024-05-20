using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exam6open : MonoBehaviour
{
    public static bool is_puz1_solved = false;
    public float pw1 = 0f;
    public float pw2 = 2f;
    public float pw3 = 8f;
    public float pw4 = 7f;
    public float pw5 = 4f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Open()
    {
        if ((pw1 == GetComponent<exam6c1>().numc) && (pw2 == GetComponent<exam6c2>().numc) &&(pw3 == GetComponent<exam6c3>().numc)&&(pw4 == GetComponent<exam6c4>().numc)&&(pw5 == GetComponent<exam6c5>().numc))
        {
            is_puz1_solved = true;
            if (is_puz1_solved == true)
            {
                Debug.Log("퍼즐1 클리어");
            }
            
        }
        // 틀렸다면 틀린 이펙트를 추가?
    }
}
