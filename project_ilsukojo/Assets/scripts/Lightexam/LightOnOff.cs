using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOnOff : MonoBehaviour
{
    public GameObject light1on, light2on, light3on, light4on, light5on;
    public GameObject light1off, light2off, light3off, light4off, light5off;

    public bool light1, light2, light3, light4, light5 = false;
    // Start is called before the first frame update
    void Start()
    {
        light1on.SetActive(false);
        light2on.SetActive(false);
        light3on.SetActive(false);
        light4on.SetActive(false);
        light5on.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Light1btn()
    {
        if (light1 == false)
        {
            light1 = true;
            light1on.SetActive(true);
            light1off.SetActive(false);
        }
        else if (light1 == true)
        {
            light1 = false;
            light1on.SetActive(false);
            light1off.SetActive(true);
        }
        if (light3 == false)
        {
            light3 = true;
            light3on.SetActive(true);
            light3off.SetActive(false);
        }
        else if (light3 == true)
        {
            light3 = false;
            light3on.SetActive(false);
            light3off.SetActive(true);
        }
        if (light5 == false)
        {
            light5 = true;
            light5on.SetActive(true);
            light5off.SetActive(false);
        }
        else if (light5 == true)
        {
            light5 = false;
            light5on.SetActive(false);
            light5off.SetActive(true);
        }
    }
    public void Light2btn()
    {
        if (light1 == false)
        {
            light1 = true;
            light1on.SetActive(true);
            light1off.SetActive(false);
        }
        else if (light1 == true)
        {
            light1 = false;
            light1on.SetActive(false);
            light1off.SetActive(true);
        }
        if (light4 == false)
        {
            light4 = true;
            light4on.SetActive(true);
            light4off.SetActive(false);
        }
        else if (light4 == true)
        {
            light4 = false;
            light4on.SetActive(false);
            light4off.SetActive(true);
        }
        if (light5 == false)
        {
            light5 = true;
            light5on.SetActive(true);
            light5off.SetActive(false);
        }
        else if (light5 == true)
        {
            light5 = false;
            light5on.SetActive(false);
            light5off.SetActive(true);
        }
    }
    public void Light3btn()
    {
        if (light1 == false)
        {
            light1 = true;
            light1on.SetActive(true);
            light1off.SetActive(false);
        }
        else if (light1 == true)
        {
            light1 = false;
            light1on.SetActive(false);
            light1off.SetActive(true);
        }
        if (light3 == false)
        {
            light3 = true;
            light3on.SetActive(true);
            light3off.SetActive(false);
        }
        else if (light3 == true)
        {
            light3 = false;
            light3on.SetActive(false);
            light3off.SetActive(true);
        }
        if (light4 == false)
        {
            light4 = true;
            light4on.SetActive(true);
            light4off.SetActive(false);
        }
        else if (light4 == true)
        {
            light4 = false;
            light4on.SetActive(false);
            light4off.SetActive(true);
        }
    }
    public void Light4btn()
    {
        if (light1 == false)
        {
            light1 = true;
            light1on.SetActive(true);
            light1off.SetActive(false);
        }
        else if (light1 == true)
        {
            light1 = false;
            light1on.SetActive(false);
            light1off.SetActive(true);
        }
        if (light2 == false)
        {
            light2 = true;
            light2on.SetActive(true);
            light2off.SetActive(false);
        }
        else if (light2 == true)
        {
            light2 = false;
            light2on.SetActive(false);
            light2off.SetActive(true);
        }
        if (light4 == false)
        {
            light4 = true;
            light4on.SetActive(true);
            light4off.SetActive(false);
        }
        else if (light4 == true)
        {
            light4 = false;
            light4on.SetActive(false);
            light4off.SetActive(true);
        }
    }

    public void Reset()
    {
        light1 = false; light2 = false; light3 = false; light4 = false; light5 = false;
        light1on.SetActive(false);
        light2on.SetActive(false);
        light3on.SetActive(false);
        light4on.SetActive(false);
        light5on.SetActive(false);

        light1off.SetActive(true);
        light2off.SetActive(true);
        light3off.SetActive(true);
        light4off.SetActive(true);
        light5off.SetActive(true);
    }

}
