using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quiz2ten : MonoBehaviour
{
    public Image ten;
    public float q2ten = 0f;
    // Start is called before the first frame update
    void Start()
    {
        ten.gameObject.SetActive(false);
    }

    public void qz2Change()
    {
        q2ten++;
        if(q2ten > 1f)
        {
            ten.gameObject.SetActive(false);
            q2ten = 0f;
        }
        if(q2ten == 1f)
        {
            ten.gameObject.SetActive(true);
        }
    }
}
