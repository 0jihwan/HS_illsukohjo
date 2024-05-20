using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastHintCheck : MonoBehaviour
{
    public GameObject HiddenExam1, HiddenExam2, HiddenExam3;
    public float H1a, H1b;
    public float H2a, H2b, H2c, H2d;
    public float H3a, H3b, H3c, H3d;
    public bool H1C, H2C, H3C,LastCheck,Ycheck = false;

    public GameObject L1ON , L2ON , L3ON;
    public GameObject L1OFF, L2OFF, L3OFF;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        H1a = HiddenExam1.GetComponent<HNumChange1>().numc;
        H1b = HiddenExam1.GetComponent<HNumChange2>().numc;
        if ((H1a == 4) && (H1b == 3))
        {
            L1ON.gameObject.SetActive(true);
            L1OFF.gameObject.SetActive(false);
            H1C = true;
        }

        H2a = HiddenExam2.GetComponent<HNChange1>().numc;
        H2b = HiddenExam2.GetComponent<HNChange2>().numc;
        H2c = HiddenExam2.GetComponent<HNChange3>().numc;
        H2d = HiddenExam2.GetComponent<HNChange4>().numc;
        if ((H2a==2) && (H2b==7) && (H2c==5) && (H2d==1))
        {
            L2ON.gameObject.SetActive(true);
            L2OFF.gameObject.SetActive(false);
            H2C = true;
        }

        H3a = HiddenExam3.GetComponent<NNumChange1>().numc;
        H3b = HiddenExam3.GetComponent<NNumChange2>().numc;
        H3c = HiddenExam3.GetComponent<NNumChange3>().numc;
        H3d = HiddenExam3.GetComponent<NNumChange4>().numc;
        if ((H3a == 7) && (H3b == 5) && (H3c == 4) && (H3d == 2))
        {
            L3ON.gameObject.SetActive(true);
            L3OFF.gameObject.SetActive(false);
            H3C = true;
        }

        if(gameObject.transform.position.y < -3.0f)
        {
            Ycheck = true;
        }

        if(LastCheck == true)
        {
            if (Ycheck ==false)
            {
                gameObject.transform.Translate(Vector3.down * Time.deltaTime, Space.World);
            }
        }
        
    }

    public void LHCheck()
    {
        if ((H1C==true)&&(H2C == true) &&(H3C == true))
        {
            LastCheck = true;
        }
    }
}
