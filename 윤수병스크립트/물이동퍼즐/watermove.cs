using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static SoundState;

public class watermove : MonoBehaviour
{
    public GameObject SDoor;
    public GameObject water3,water5,water8;
    public bool w3on, w5on, w8on=false;
    public Image w31, w32, w33;
    public Image w51, w52, w53, w54, w55;
    public Image w81, w82, w83, w84, w85, w86, w87, w88;
    public enum wstate
    {
        S053,S503,S800,S530,S350,S323,S233,S620,S251,S602,S701,S710,S152,S143,S413,S440
    }
    public wstate state;
    // Start is called before the first frame update
    void Start()
    {
        state = wstate.S053;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void on3()
    {
        if(w3on==false)
        {
            if (w5on==true) 
            {
                water5.transform.position = new Vector3 (1250,545,0);
                water5.transform.eulerAngles = new Vector3(0, 0, -90);
                Invoke("W2to3", 0f);
                Invoke("origin5", 0.5f);
            }
            else if (w8on == true)
            {
                water8.transform.position = new Vector3(1180, 860, 0);
                water8.transform.eulerAngles = new Vector3(0, 0, -90);
                Invoke("W1to3", 0f);
                Invoke("origin8", 0.5f);
            }
            else if((w5on==false)&&(w8on==false)) 
            { 
            water3.transform.position += new Vector3(0,500,0);
            w3on = true;
            }
        }
        else if(w3on == true) 
        {
            Invoke("origin3", 0f);
        }
    }
    public void on5()
    {
        if (w5on == false)
        {
            if (w3on == true)
            {
                water3.transform.position = new Vector3(1400, 665, 0);
                water3.transform.eulerAngles = new Vector3(0, 0, 90);
                Invoke("W3to2", 0f);
                Invoke("origin3", 0.5f);
            }
            else if(w8on == true)
            {
                water8.transform.position = new Vector3(680, 845, 0);
                water8.transform.eulerAngles = new Vector3(0, 0, -90);
                Invoke("W1to2", 0f);
                Invoke("origin8", 0.5f);
            }
            else if ((w3on == false)&&(w8on == false))
            {
            water5.transform.position += new Vector3(0, 300, 0);
            w5on = true;
            }
        }
        else if (w5on == true)
        {
            Invoke("origin5", 0f);
        }
    }
    public void on8()
    {
        if (w8on == false)
        {
            if (w3on == true)
            {
                water3.transform.position = new Vector3(900, 850, 0);
                water3.transform.eulerAngles = new Vector3(0, 0, 90);
               
                Invoke("W3to1", 0.1f);
                Invoke("origin3", 0.5f);
            }
            if (w5on == true)
            {
                water5.transform.position = new Vector3(1010, 950, 0);
                water5.transform.eulerAngles = new Vector3(0, 0, 90);
                
                Invoke("W2to1", 0.1f);
                Invoke("origin5", 0.5f);
            }
            else if ((w3on == false) && (w5on == false))
            {
                water8.transform.position += new Vector3(0, 100, 0);
                w8on = true;
            }
        }
        else if (w8on == true)
        {
            Invoke("origin8", 0f);
        }
    }
    
    private void origin3()
    {
        water3.transform.position = new Vector3(1530, 240, 0);
        water3.transform.eulerAngles = new Vector3(0, 0, 0);
        w3on = false;
    }
    private void origin5()
    {
        water5.transform.position = new Vector3(1145, 340, 0);
        water5.transform.eulerAngles = new Vector3(0, 0, 0);
        w5on = false;
    }
    private void origin8()
    {
        water8.transform.position = new Vector3(545, 440, 0);
        water8.transform.eulerAngles = new Vector3(0, 0, 0);
        w8on = false;
    }

    private void W2to3()
    {
        if (state == wstate.S530)
        {
            state = wstate.S503;
            w53.gameObject.SetActive(false);
            w33.gameObject.SetActive(true);
        }
        if(state == wstate.S350)
        {
            state = wstate.S323;
            w55.gameObject.SetActive(false);
            w52.gameObject.SetActive(true);
            w33.gameObject.SetActive(true);
        }
        if (state == wstate.S620)
        {
            state = wstate.S602;
            w52.gameObject.SetActive(false);
            w32.gameObject.SetActive(true);
        }
        if (state == wstate.S251)
        {
            state = wstate.S233;
            w55.gameObject.SetActive(false);
            w53.gameObject.SetActive(true);
            w31.gameObject.SetActive(false);
            w33.gameObject.SetActive(true);
        }
        if (state == wstate.S710)
        {
            state = wstate.S701;
            w51.gameObject.SetActive(false);
            w31.gameObject.SetActive(true);
        }
        if (state == wstate.S152)
        {
            state = wstate.S143;
            w55.gameObject.SetActive(false);
            w54.gameObject.SetActive(true);
            w32.gameObject.SetActive(false);
            w33.gameObject.SetActive(true);
        }
    }
    private void W1to3()
    {
        if (state == wstate.S800)
        {
            state = wstate.S503;
            w88.gameObject.SetActive(false);
            w85.gameObject.SetActive(true);
            w33.gameObject.SetActive(true);
        }
        if (state == wstate.S530)
        {
            state = wstate.S233;
            w85.gameObject.SetActive(false);
            w82.gameObject.SetActive(true);
            w33.gameObject.SetActive(true);
        }
        if (state == wstate.S350)
        {
            state = wstate.S053;
            w83.gameObject.SetActive(false);
            w33.gameObject.SetActive(true);
        }
        if (state == wstate.S620)
        {
            state = wstate.S323;
            w86.gameObject.SetActive(false);
            w83.gameObject.SetActive(true);
            w33.gameObject.SetActive(true);
        }
        if (state == wstate.S251)
        {
            state = wstate.S053;
            w82.gameObject.SetActive(false);
            w31.gameObject.SetActive(false);
            w33.gameObject.SetActive(true);
        }
        if (state == wstate.S602)
        {
            state = wstate.S503;
            w86.gameObject.SetActive(false);
            w85.gameObject.SetActive(true);
            w32.gameObject.SetActive(false);
            w33.gameObject.SetActive(true);
        }
        if (state == wstate.S701)
        {
            state = wstate.S503;
            w87.gameObject.SetActive(false);
            w85.gameObject.SetActive(true);
            w31.gameObject.SetActive(false);
            w33.gameObject.SetActive(true);
        }
        if (state == wstate.S710)
        {
            state = wstate.S413;
            w87.gameObject.SetActive(false);
            w84.gameObject.SetActive(true);
            w33.gameObject.SetActive(true);
            SDoor.transform.position = new Vector3(0f, 1.2f, 8.6f);
            SDoor.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            GetComponent<waterUIon>().Wsolve = true;
        }
        if (state == wstate.S152)
        {
            state = wstate.S053;
            w81.gameObject.SetActive(false);
            w32.gameObject.SetActive(false);
            w33.gameObject.SetActive(true);
        }
    }
    private void W3to2()
    {
        if (state == wstate.S503)
        {
            state = wstate.S530;
            w33.gameObject.SetActive(false);
            w53.gameObject.SetActive(true);
        }
        if (state == wstate.S323)
        {
            state = wstate.S350;
            w33.gameObject.SetActive(false);
            w52.gameObject.SetActive(false);
            w55.gameObject.SetActive(true);
        }
        if (state == wstate.S233)
        {
            state = wstate.S251;
            w33.gameObject.SetActive(false);
            w31.gameObject.SetActive(true);
            w53.gameObject.SetActive(false);
            w55.gameObject.SetActive(true);
        }
        if (state == wstate.S602)
        {
            state = wstate.S620;
            w32.gameObject.SetActive(false);
            w52.gameObject.SetActive(true);
        }
        if (state == wstate.S701)
        {
            state = wstate.S710;
            w31.gameObject.SetActive(false);
            w51.gameObject.SetActive(true);
        }
        if (state == wstate.S143)
        {
            state = wstate.S152;
            w33.gameObject.SetActive(false);
            w32.gameObject.SetActive(true);
            w54.gameObject.SetActive(false);
            w55.gameObject.SetActive(true);
        }
    }
    private void W1to2()
    {
        if (state == wstate.S503)
        {
            state = wstate.S053;
            w85.gameObject.SetActive(false);
            w55.gameObject.SetActive(true);
        }
        if (state == wstate.S800)
        {
            state = wstate.S350;
            w88.gameObject.SetActive(false);
            w83.gameObject.SetActive(true);
            w55.gameObject.SetActive(true);
        }
        if (state == wstate.S530)
        {
            state = wstate.S350;
            w85.gameObject.SetActive(false);
            w83.gameObject.SetActive(true);
            w53.gameObject.SetActive(false);
            w55.gameObject.SetActive(true);
        }
        if (state == wstate.S323)
        {
            state = wstate.S053;
            w83.gameObject.SetActive(false);;
            w52.gameObject.SetActive(false);
            w55.gameObject.SetActive(true);
        }
        if (state == wstate.S233)
        {
            state = wstate.S053;
            w82.gameObject.SetActive(false);
            w53.gameObject.SetActive(false);
            w55.gameObject.SetActive(true);
        }
        if (state == wstate.S620)
        {
            state = wstate.S350;
            w86.gameObject.SetActive(false);
            w83.gameObject.SetActive(true);
            w52.gameObject.SetActive(false);
            w55.gameObject.SetActive(true);
        }
        if (state == wstate.S602)
        {
            state = wstate.S152;
            w86.gameObject.SetActive(false);
            w81.gameObject.SetActive(true);
            w55.gameObject.SetActive(true);
        }
        if (state == wstate.S701)
        {
            state = wstate.S251;
            w87.gameObject.SetActive(false);
            w82.gameObject.SetActive(true);
            w55.gameObject.SetActive(true);
        }
        if (state == wstate.S710)
        {
            state = wstate.S350;
            w87.gameObject.SetActive(false);
            w83.gameObject.SetActive(true);
            w51.gameObject.SetActive(false);
            w55.gameObject.SetActive(true);
        }
        if (state == wstate.S143)
        {
            state = wstate.S053;
            w81.gameObject.SetActive(false);
            w54.gameObject.SetActive(false);
            w55.gameObject.SetActive(true);
        }
    }
    private void W3to1()
    {
        if (state == wstate.S053)
        {
            state = wstate.S350;
            w33.gameObject.SetActive(false);
            w83.gameObject.SetActive(true);
        }
        if (state == wstate.S503)
        {
            state = wstate.S800;
            w33.gameObject.SetActive(false);
            w85.gameObject.SetActive(false);
            w88.gameObject.SetActive(true);
        }
        if (state == wstate.S323)
        {
            state = wstate.S620;
            w33.gameObject.SetActive(false);
            w83.gameObject.SetActive(false);
            w86.gameObject.SetActive(true);
        }
        if (state == wstate.S233)
        {
            state = wstate.S530;
            w33.gameObject.SetActive(false);
            w82.gameObject.SetActive(false);
            w85.gameObject.SetActive(true);
        }
        if (state == wstate.S251)
        {
            state = wstate.S350;
            w31.gameObject.SetActive(false);
            w82.gameObject.SetActive(false);
            w83.gameObject.SetActive(true);
        }
        if (state == wstate.S602)
        {
            state = wstate.S800;
            w32.gameObject.SetActive(false);
            w86.gameObject.SetActive(false);
            w88.gameObject.SetActive(true);
        }
        if (state == wstate.S701)
        {
            state = wstate.S800;
            w31.gameObject.SetActive(false);
            w87.gameObject.SetActive(false);
            w88.gameObject.SetActive(true);
        }
        if (state == wstate.S152)
        {
            state = wstate.S350;
            w32.gameObject.SetActive(false);
            w81.gameObject.SetActive(false);
            w83.gameObject.SetActive(true);
        }
        if (state == wstate.S143)
        {
            state = wstate.S440;
            w33.gameObject.SetActive(false);
            w81.gameObject.SetActive(false);
            w84.gameObject.SetActive(true);
            SDoor.transform.position = new Vector3(0f, 1.2f, 8.6f);
            SDoor.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            GetComponent<waterUIon>().Wsolve = true;
        }
    }
    private void W2to1()
    {
        if (state == wstate.S053)
        {
            state = wstate.S503;
            w85.gameObject.SetActive(true);
            w55.gameObject.SetActive(false);
        }
        if (state == wstate.S530)
        {
            state = wstate.S800;
            w53.gameObject.SetActive(false);
            w85.gameObject.SetActive(false);
            w88.gameObject.SetActive(true);
        }
        if (state == wstate.S350)
        {
            state = wstate.S800;
            w55.gameObject.SetActive(false);
            w83.gameObject.SetActive(false);
            w88.gameObject.SetActive(true);
        }
        if (state == wstate.S323)
        {
            state = wstate.S503;
            w52.gameObject.SetActive(false);
            w83.gameObject.SetActive(false);
            w85.gameObject.SetActive(true);
        }
        if (state == wstate.S233)
        {
            state = wstate.S503;
            w53.gameObject.SetActive(false);
            w82.gameObject.SetActive(false);
            w85.gameObject.SetActive(true);
        }
        if (state == wstate.S620)
        {
            state = wstate.S800;
            w52.gameObject.SetActive(false);
            w86.gameObject.SetActive(false);
            w88.gameObject.SetActive(true);
        }
        if (state == wstate.S251)
        {
            state = wstate.S701;
            w55.gameObject.SetActive(false);
            w82.gameObject.SetActive(false);
            w87.gameObject.SetActive(true);
        }
        if (state == wstate.S710)
        {
            state = wstate.S800;
            w51.gameObject.SetActive(false);
            w87.gameObject.SetActive(false);
            w88.gameObject.SetActive(true);
        }
        if (state == wstate.S152)
        {
            state = wstate.S602;
            w55.gameObject.SetActive(false);
            w81.gameObject.SetActive(false);
            w86.gameObject.SetActive(true);
        }
        if (state == wstate.S143)
        {
            state = wstate.S503;
            w54.gameObject.SetActive(false);
            w81.gameObject.SetActive(false);
            w85.gameObject.SetActive(true);
        }
    }
}
