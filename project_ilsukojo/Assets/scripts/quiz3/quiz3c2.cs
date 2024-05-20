using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quiz3c2 : MonoBehaviour
{
    public Image q3i1;
    public Image q3i2;
    public Image q3i3;
    public Image q3i4;
    public Image q3i5;
    public Image q3i6;
    public Image q3i7;
    public Image q3i8;
    public Image q3i9;
    public float q3numc = 0f;

    // Start is called before the first frame update
    void Start()
    {
        q3i1.gameObject.SetActive(true);
        q3i2.gameObject.SetActive(false);
        q3i3.gameObject.SetActive(false);
        q3i4.gameObject.SetActive(false);
        q3i5.gameObject.SetActive(false);
        q3i6.gameObject.SetActive(false);
        q3i7.gameObject.SetActive(false);
        q3i8.gameObject.SetActive(false);
        q3i9.gameObject.SetActive(false);
    }

    public void qz3Change()
    {
        q3numc++;
        Debug.Log("버튼을 누르셨습니다.");
        if (q3numc > 8f)
        {
            q3numc = 0f;
        }
        if (q3numc == 0f)
        {
            q3i1.gameObject.SetActive(true);
            q3i2.gameObject.SetActive(false);
            q3i3.gameObject.SetActive(false);
            q3i4.gameObject.SetActive(false);
            q3i5.gameObject.SetActive(false);
            q3i6.gameObject.SetActive(false);
            q3i7.gameObject.SetActive(false);
            q3i8.gameObject.SetActive(false);
            q3i9.gameObject.SetActive(false);

        }
        if (q3numc == 1f)
        {
            q3i1.gameObject.SetActive(false);
            q3i2.gameObject.SetActive(true);
            q3i3.gameObject.SetActive(false);
            q3i4.gameObject.SetActive(false);
            q3i5.gameObject.SetActive(false);
            q3i6.gameObject.SetActive(false);
            q3i7.gameObject.SetActive(false);
            q3i8.gameObject.SetActive(false);
            q3i9.gameObject.SetActive(false);

        }
        if (q3numc == 2f)
        {
            q3i1.gameObject.SetActive(false);
            q3i2.gameObject.SetActive(false);
            q3i3.gameObject.SetActive(true);
            q3i4.gameObject.SetActive(false);
            q3i5.gameObject.SetActive(false);
            q3i6.gameObject.SetActive(false);
            q3i7.gameObject.SetActive(false);
            q3i8.gameObject.SetActive(false);
            q3i9.gameObject.SetActive(false);

        }
        if (q3numc == 3f)
        {
            q3i1.gameObject.SetActive(false);
            q3i2.gameObject.SetActive(false);
            q3i3.gameObject.SetActive(false);
            q3i4.gameObject.SetActive(true);
            q3i5.gameObject.SetActive(false);
            q3i6.gameObject.SetActive(false);
            q3i7.gameObject.SetActive(false);
            q3i8.gameObject.SetActive(false);
            q3i9.gameObject.SetActive(false);

        }
        if (q3numc == 4f)
        {
            q3i1.gameObject.SetActive(false);
            q3i2.gameObject.SetActive(false);
            q3i3.gameObject.SetActive(false);
            q3i4.gameObject.SetActive(false);
            q3i5.gameObject.SetActive(true);
            q3i6.gameObject.SetActive(false);
            q3i7.gameObject.SetActive(false);
            q3i8.gameObject.SetActive(false);
            q3i9.gameObject.SetActive(false);

        }
        if (q3numc == 5f)
        {
            q3i1.gameObject.SetActive(false);
            q3i2.gameObject.SetActive(false);
            q3i3.gameObject.SetActive(false);
            q3i4.gameObject.SetActive(false);
            q3i5.gameObject.SetActive(false);
            q3i6.gameObject.SetActive(true);
            q3i7.gameObject.SetActive(false);
            q3i8.gameObject.SetActive(false);
            q3i9.gameObject.SetActive(false);

        }
        if (q3numc == 6f)
        {
            q3i1.gameObject.SetActive(false);
            q3i2.gameObject.SetActive(false);
            q3i3.gameObject.SetActive(false);
            q3i4.gameObject.SetActive(false);
            q3i5.gameObject.SetActive(false);
            q3i6.gameObject.SetActive(false);
            q3i7.gameObject.SetActive(true);
            q3i8.gameObject.SetActive(false);
            q3i9.gameObject.SetActive(false);

        }
        if (q3numc == 7f)
        {
            q3i1.gameObject.SetActive(false);
            q3i2.gameObject.SetActive(false);
            q3i3.gameObject.SetActive(false);
            q3i4.gameObject.SetActive(false);
            q3i5.gameObject.SetActive(false);
            q3i6.gameObject.SetActive(false);
            q3i7.gameObject.SetActive(false);
            q3i8.gameObject.SetActive(true);
            q3i9.gameObject.SetActive(false);

        }
        if (q3numc == 8f)
        {
            q3i1.gameObject.SetActive(false);
            q3i2.gameObject.SetActive(false);
            q3i3.gameObject.SetActive(false);
            q3i4.gameObject.SetActive(false);
            q3i5.gameObject.SetActive(false);
            q3i6.gameObject.SetActive(false);
            q3i7.gameObject.SetActive(false);
            q3i8.gameObject.SetActive(false);
            q3i9.gameObject.SetActive(true);

        }

    }
}

