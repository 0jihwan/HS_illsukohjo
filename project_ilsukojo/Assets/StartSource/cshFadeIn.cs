using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class cshFadeIn : MonoBehaviour
{

    GameObject SplashObj;
    Image image; //판넬이미지
    private bool checkbool = false;     //투명도 조절
    private float fadespeed = 0.005f;  //투명도 조절 속도
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
            Destroy(this.gameObject);   // 검은 화면 제거
        }
    }

    public IEnumerator MainSplash()
    {
        //
        Color color = image.color;
        for (int i = 0; i < 100; i++)
        {
            //image.color.a = 255; 초기 a값 255
            float Cosa = Mathf.Sin((pi/66)*i);
            float realA = Mathf.Abs(Cosa);

            //color.a -= Time.deltaTime * fadespeed;
            if (i > 66 || i<= 33)//밝아졌다
            {
                color.a -= realA*Time.deltaTime*fadespeed;
            }
            else
            {   //이거 왜 조건문인데 둘 다 적용되냐? 이해가안되네
                color.a += realA*Time.deltaTime*fadespeed;
                //Debug.Log("기울기 음수");
                

            }

            
            //color.a = realA;

            //fadespeed = fadespeed + 0.0000003f;    //좀더 연출처럼 보이려면 sin 절댓값 함수? 써야할거같기도
            image.color = color;    // 계산한 투명도를 이미지에 적용
            if (image.color.a <= 0 && i == 99)
            {
                //Debug.Log(fadespeed);
                checkbool = true;
            }
            //yield return null; //다음프레임까지 대기
        }
        yield return null; //다음프레임까지 대기
    }
}