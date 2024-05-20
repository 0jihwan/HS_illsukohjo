using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quiz2c2 : MonoBehaviour
{
    public Image q2i1;
    public Image q2i2;
    public Image q2i3;
    public Image q2i4;
    public Image q2i5;
    public Image q2i6;
    public Image q2i7;
    public Image q2i8;
    public Image q2i9;
    public float q2numc = 0f;

    // Start is called before the first frame update
    void Start()
    {
        q2i1.gameObject.SetActive(true);
        q2i2.gameObject.SetActive(false);
        q2i3.gameObject.SetActive(false);
        q2i4.gameObject.SetActive(false);
        q2i5.gameObject.SetActive(false);
        q2i6.gameObject.SetActive(false);
        q2i7.gameObject.SetActive(false);
        q2i8.gameObject.SetActive(false);
        q2i9.gameObject.SetActive(false);
    }

    public void qz2Change()
    {
        q2numc++;
        if (q2numc > 8f)
        {
            q2numc = 0f;
        }
        if (q2numc == 0f)
        {
            q2i1.gameObject.SetActive(true);
            q2i2.gameObject.SetActive(false);
            q2i3.gameObject.SetActive(false);
            q2i4.gameObject.SetActive(false);
            q2i5.gameObject.SetActive(false);
            q2i6.gameObject.SetActive(false);
            q2i7.gameObject.SetActive(false);
            q2i8.gameObject.SetActive(false);
            q2i9.gameObject.SetActive(false);

        }
        if (q2numc == 1f)
        {
            q2i1.gameObject.SetActive(false);
            q2i2.gameObject.SetActive(true);
            q2i3.gameObject.SetActive(false);
            q2i4.gameObject.SetActive(false);
            q2i5.gameObject.SetActive(false);
            q2i6.gameObject.SetActive(false);
            q2i7.gameObject.SetActive(false);
            q2i8.gameObject.SetActive(false);
            q2i9.gameObject.SetActive(false);

        }
        if (q2numc == 2f)
        {
            q2i1.gameObject.SetActive(false);
            q2i2.gameObject.SetActive(false);
            q2i3.gameObject.SetActive(true);
            q2i4.gameObject.SetActive(false);
            q2i5.gameObject.SetActive(false);
            q2i6.gameObject.SetActive(false);
            q2i7.gameObject.SetActive(false);
            q2i8.gameObject.SetActive(false);
            q2i9.gameObject.SetActive(false);

        }
        if (q2numc == 3f)
        {
            q2i1.gameObject.SetActive(false);
            q2i2.gameObject.SetActive(false);
            q2i3.gameObject.SetActive(false);
            q2i4.gameObject.SetActive(true);
            q2i5.gameObject.SetActive(false);
            q2i6.gameObject.SetActive(false);
            q2i7.gameObject.SetActive(false);
            q2i8.gameObject.SetActive(false);
            q2i9.gameObject.SetActive(false);

        }
        if (q2numc == 4f)
        {
            q2i1.gameObject.SetActive(false);
            q2i2.gameObject.SetActive(false);
            q2i3.gameObject.SetActive(false);
            q2i4.gameObject.SetActive(false);
            q2i5.gameObject.SetActive(true);
            q2i6.gameObject.SetActive(false);
            q2i7.gameObject.SetActive(false);
            q2i8.gameObject.SetActive(false);
            q2i9.gameObject.SetActive(false);

        }
        if (q2numc == 5f)
        {
            q2i1.gameObject.SetActive(false);
            q2i2.gameObject.SetActive(false);
            q2i3.gameObject.SetActive(false);
            q2i4.gameObject.SetActive(false);
            q2i5.gameObject.SetActive(false);
            q2i6.gameObject.SetActive(true);
            q2i7.gameObject.SetActive(false);
            q2i8.gameObject.SetActive(false);
            q2i9.gameObject.SetActive(false);

        }
        if (q2numc == 6f)
        {
            q2i1.gameObject.SetActive(false);
            q2i2.gameObject.SetActive(false);
            q2i3.gameObject.SetActive(false);
            q2i4.gameObject.SetActive(false);
            q2i5.gameObject.SetActive(false);
            q2i6.gameObject.SetActive(false);
            q2i7.gameObject.SetActive(true);
            q2i8.gameObject.SetActive(false);
            q2i9.gameObject.SetActive(false);

        }
        if (q2numc == 7f)
        {
            q2i1.gameObject.SetActive(false);
            q2i2.gameObject.SetActive(false);
            q2i3.gameObject.SetActive(false);
            q2i4.gameObject.SetActive(false);
            q2i5.gameObject.SetActive(false);
            q2i6.gameObject.SetActive(false);
            q2i7.gameObject.SetActive(false);
            q2i8.gameObject.SetActive(true);
            q2i9.gameObject.SetActive(false);

        }
        if (q2numc == 8f)
        {
            q2i1.gameObject.SetActive(false);
            q2i2.gameObject.SetActive(false);
            q2i3.gameObject.SetActive(false);
            q2i4.gameObject.SetActive(false);
            q2i5.gameObject.SetActive(false);
            q2i6.gameObject.SetActive(false);
            q2i7.gameObject.SetActive(false);
            q2i8.gameObject.SetActive(false);
            q2i9.gameObject.SetActive(true);

        }

    }
}
