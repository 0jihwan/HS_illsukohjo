using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quiz3open : MonoBehaviour
{
    public static bool is_puz3_solved = false;
    public float qz3Pw1 = 6f;
    public float qz3Pw2 = 5f;
    public float qz3Pw3 = 2f;
    public float qz3Pw4 = 1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void qz3Open()
    {
        if ((qz3Pw1 == GetComponent<quiz3c1>().q3numc) && (qz3Pw2 == GetComponent<quiz3c2>().q3numc) && (qz3Pw3 == GetComponent<quiz3c3>().q3numc) && (qz3Pw4 == GetComponent<quiz3c4>().q3numc))
        {
            is_puz3_solved = true;
            if (is_puz3_solved == true)
            {
                Debug.Log("퍼즐3 클리어");
            }
        }
        // 틀렸다면 틀린 이펙트를 추가?
    }
}
