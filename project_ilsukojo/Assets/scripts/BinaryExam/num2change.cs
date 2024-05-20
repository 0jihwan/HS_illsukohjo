using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class num2change : MonoBehaviour
{
    public Image i1;
    public Image i2;
    public Image i3;
    public Image i4;
    public Image i5;
    public Image i6;
    public Image i7;
    public Image i8;
    public Image i9;
    public Image i10;
    public float numc = 0f;
    // Start is called before the first frame update
    void Start()
    {
        i1.gameObject.SetActive(true);
        i2.gameObject.SetActive(false);
        i3.gameObject.SetActive(false);
        i4.gameObject.SetActive(false);
        i5.gameObject.SetActive(false);
        i6.gameObject.SetActive(false);
        i7.gameObject.SetActive(false);
        i8.gameObject.SetActive(false);
        i9.gameObject.SetActive(false);
        i10.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void change()
    {
        numc++;
        if (numc > 9f)
        {
            numc = 0f;
        }
        if (numc == 0f)
        {
            i1.gameObject.SetActive(true);
            i2.gameObject.SetActive(false);
            i3.gameObject.SetActive(false);
            i4.gameObject.SetActive(false);
            i5.gameObject.SetActive(false);
            i6.gameObject.SetActive(false);
            i7.gameObject.SetActive(false);
            i8.gameObject.SetActive(false);
            i9.gameObject.SetActive(false);
            i10.gameObject.SetActive(false);
        }
        if (numc == 1f)
        {
            i1.gameObject.SetActive(false);
            i2.gameObject.SetActive(true);
            i3.gameObject.SetActive(false);
            i4.gameObject.SetActive(false);
            i5.gameObject.SetActive(false);
            i6.gameObject.SetActive(false);
            i7.gameObject.SetActive(false);
            i8.gameObject.SetActive(false);
            i9.gameObject.SetActive(false);
            i10.gameObject.SetActive(false);
        }
        if (numc == 2f)
        {
            i1.gameObject.SetActive(false);
            i2.gameObject.SetActive(false);
            i3.gameObject.SetActive(true);
            i4.gameObject.SetActive(false);
            i5.gameObject.SetActive(false);
            i6.gameObject.SetActive(false);
            i7.gameObject.SetActive(false);
            i8.gameObject.SetActive(false);
            i9.gameObject.SetActive(false);
            i10.gameObject.SetActive(false);
        }
        if (numc == 3f)
        {
            i1.gameObject.SetActive(false);
            i2.gameObject.SetActive(false);
            i3.gameObject.SetActive(false);
            i4.gameObject.SetActive(true);
            i5.gameObject.SetActive(false);
            i6.gameObject.SetActive(false);
            i7.gameObject.SetActive(false);
            i8.gameObject.SetActive(false);
            i9.gameObject.SetActive(false);
            i10.gameObject.SetActive(false);
        }
        if (numc == 4f)
        {
            i1.gameObject.SetActive(false);
            i2.gameObject.SetActive(false);
            i3.gameObject.SetActive(false);
            i4.gameObject.SetActive(false);
            i5.gameObject.SetActive(true);
            i6.gameObject.SetActive(false);
            i7.gameObject.SetActive(false);
            i8.gameObject.SetActive(false);
            i9.gameObject.SetActive(false);
            i10.gameObject.SetActive(false);
        }
        if (numc == 5f)
        {
            i1.gameObject.SetActive(false);
            i2.gameObject.SetActive(false);
            i3.gameObject.SetActive(false);
            i4.gameObject.SetActive(false);
            i5.gameObject.SetActive(false);
            i6.gameObject.SetActive(true);
            i7.gameObject.SetActive(false);
            i8.gameObject.SetActive(false);
            i9.gameObject.SetActive(false);
            i10.gameObject.SetActive(false);
        }
        if (numc == 6f)
        {
            i1.gameObject.SetActive(false);
            i2.gameObject.SetActive(false);
            i3.gameObject.SetActive(false);
            i4.gameObject.SetActive(false);
            i5.gameObject.SetActive(false);
            i6.gameObject.SetActive(false);
            i7.gameObject.SetActive(true);
            i8.gameObject.SetActive(false);
            i9.gameObject.SetActive(false);
            i10.gameObject.SetActive(false);
        }
        if (numc == 7f)
        {
            i1.gameObject.SetActive(false);
            i2.gameObject.SetActive(false);
            i3.gameObject.SetActive(false);
            i4.gameObject.SetActive(false);
            i5.gameObject.SetActive(false);
            i6.gameObject.SetActive(false);
            i7.gameObject.SetActive(false);
            i8.gameObject.SetActive(true);
            i9.gameObject.SetActive(false);
            i10.gameObject.SetActive(false);
        }
        if (numc == 8f)
        {
            i1.gameObject.SetActive(false);
            i2.gameObject.SetActive(false);
            i3.gameObject.SetActive(false);
            i4.gameObject.SetActive(false);
            i5.gameObject.SetActive(false);
            i6.gameObject.SetActive(false);
            i7.gameObject.SetActive(false);
            i8.gameObject.SetActive(false);
            i9.gameObject.SetActive(true);
            i10.gameObject.SetActive(false);
        }
        if (numc == 9f)
        {
            i1.gameObject.SetActive(false);
            i2.gameObject.SetActive(false);
            i3.gameObject.SetActive(false);
            i4.gameObject.SetActive(false);
            i5.gameObject.SetActive(false);
            i6.gameObject.SetActive(false);
            i7.gameObject.SetActive(false);
            i8.gameObject.SetActive(false);
            i9.gameObject.SetActive(false);
            i10.gameObject.SetActive(true);
        }
    }
}
