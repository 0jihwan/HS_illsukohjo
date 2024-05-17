using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class cshFadeIn : MonoBehaviour
{

    GameObject SplashObj;
    Image image; //�ǳ��̹���
    private bool checkbool = false;     //���� ����
    private float fadespeed = 0.005f;  //���� ���� �ӵ�
    private float pi = Mathf.PI;

    void Awake()
    {
        SplashObj = this.gameObject;
        image = SplashObj.GetComponent<Image>();
    }

    void Update()
    {
        StartCoroutine(MainSplash());
        if (checkbool)
        {
            Destroy(this.gameObject);   // ���� ȭ�� ����
        }
    }

    public IEnumerator MainSplash()
    {
        //
        Color color = image.color;
        for (int i = 0; i < 100; i++)
        {
            //image.color.a = 255; �ʱ� a�� 255
            float Cosa = Mathf.Sin((pi/66)*i);
            float realA = Mathf.Abs(Cosa);

            //color.a -= Time.deltaTime * fadespeed;
            if (i > 66 || i<= 33)//�������
            {
                color.a -= realA*Time.deltaTime*fadespeed;
            }
            else
            {   //�̰� �� ���ǹ��ε� �� �� ����ǳ�? ���ذ��ȵǳ�
                color.a += realA*Time.deltaTime*fadespeed;
                //Debug.Log("���� ����");
                

            }

            
            //color.a = realA;

            //fadespeed = fadespeed + 0.0000003f;    //���� ����ó�� ���̷��� sin ���� �Լ�? ����ҰŰ��⵵
            image.color = color;    // ����� ������ �̹����� ����
            if (image.color.a <= 0 && i == 99)
            {
                //Debug.Log(fadespeed);
                checkbool = true;
            }
            //yield return null; //���������ӱ��� ���
        }
        yield return null; //���������ӱ��� ���
    }
}