using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quiz2open : MonoBehaviour
{
    public static bool is_puz2_solved = false;
    public float qz2Pw1 = 1f;
    public float qz2Pw2 = 1f;
    public float qz2Pw3 = 7f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void qz2Open()
    {
        if ((qz2Pw1 == GetComponent<quiz2c1>().q2numc) && (qz2Pw3 == GetComponent<quiz2c2>().q2numc) && (qz2Pw2 == GetComponent<quiz2ten>().q2ten))
        {
            is_puz2_solved = true;
            if (is_puz2_solved == true)
            {
                Debug.Log("퍼즐2 클리어");
            }
        }
        // 틀렸다면 틀린 이펙트를 추가?
    }
}
