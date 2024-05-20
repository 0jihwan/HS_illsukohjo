using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Binarycheck : MonoBehaviour
{
    public float a,b,c,d = 0;
    public bool Bsolve = false;

    public GameObject LHint2, Lbtn2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        a = gameObject.GetComponent<num1change>().numc;
        b = gameObject.GetComponent<num2change>().numc;
        c = gameObject.GetComponent<num3change>().numc;
        d = gameObject.GetComponent<num4change>().numc;

        if (Bsolve == true)
        {
            LHint2.gameObject.SetActive(true);
            Lbtn2.gameObject.SetActive(true);
        }
    }
    public void check()
    {
        if ((a == 1) && (b == 6) && (c == 5) && (d == 0))
        {
            Bsolve = true;
        }
    }

}
