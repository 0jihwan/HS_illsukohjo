using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class btnchange1 : MonoBehaviour
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
    public float numc1 = 0f;

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

    public void change()
    {
        numc1++;
        if (numc1 > 9f)
        {
            numc1 = 0f;
        }
        if (numc1 == 0f)
        {
            i1.gameObject.SetActive(true);
            i10.gameObject.SetActive(false);
        }
        if (numc1 == 1f)
        {
            i1.gameObject.SetActive(false);
            i2.gameObject.SetActive(true);
            
        }
        if (numc1 == 2f)
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
        if (numc1 == 3f)
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
        if (numc1 == 4f)
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
        if (numc1 == 5f)
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
        if (numc1 == 6f)
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
        if (numc1 == 7f)
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
        if (numc1 == 8f)
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
        if (numc1 == 9f)
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
