using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class cshFadeController : MonoBehaviour
{
    public bool isFadeIn;   // true - FadeIn, false - Fadeout
    public GameObject panel;
    private Action onCompleteCallback;  //Fade 다음에 진행할 함수
    public GameObject startobject;
    Image startpanel;
    private bool isStart;

    void Start()
    {
        startpanel = startobject.GetComponent<Image>();
        if (isFadeIn)
        {
            panel.SetActive(true);
            StartCoroutine(Blink());
        }
        else
        {
            panel.SetActive(false); //
            StartCoroutine(CoFadeOut());
        }
    }
    IEnumerator Blink()
    {
        if (!isStart)
        {
            while (!isStart)
            {
                StartCoroutine(CoFadeIn());
                yield return new WaitForSeconds(3);
                StartCoroutine(CoFadeOut());
                yield return new WaitForSeconds(7);
            }
        }
    }
    public void FadeOut()
    {
        panel.SetActive(true);
        Debug.Log("페이드아웃 시작");
        StartCoroutine(CoFadeOut());
        Debug.Log("페이드아웃 끝");
    }
    IEnumerator CoFadeIn()  //투명해졌다가
    {
        float elapsedTime = 0f;
        float fadedTime = 2.5f;

        while(elapsedTime < fadedTime) { 
            panel.GetComponent<CanvasRenderer>().SetAlpha(Mathf.Lerp(1f, 0.3f, elapsedTime/fadedTime));
            elapsedTime += Time.deltaTime;
            //Debug.Log("페이드인 중...");
            yield return null;
        }
        //Debug.Log("페이드인 끝");
        //panel.SetActive(false); //panel 비활성화
        onCompleteCallback?.Invoke();   // 이후에 해야 하는 액션이 있는 경우 진행한다
        yield break;
    }
    IEnumerator CoFadeOut() // 원래대로 돌아오기
    {
        float elapsedTime = 0f;
        float fadedTime = 2.5f;

        while(elapsedTime <= fadedTime)
        {
            panel.GetComponent<CanvasRenderer>().SetAlpha(Mathf.Lerp(0.3f, 1f, elapsedTime / fadedTime));
            elapsedTime += Time.deltaTime;
            //Debug.Log("페이드아웃 중...");
            yield return null;
        }
        //Debug.Log("페이드아웃 끝");
        onCompleteCallback?.Invoke();
        yield break;
    }
    public void RegisterCallback(Action callback)
    {
        onCompleteCallback = callback;
    }

    IEnumerator startFadeOut()
    {
        float elapsedTime = 0f;
        float fadedTime = 2.0f;
        Color color = startpanel.color;
        //yield return new WaitForSeconds(0.5f);
        
        while (elapsedTime <= fadedTime)
        {
            color.a = Mathf.Lerp(0f, 1f, elapsedTime / fadedTime);
            //color.a += Time.deltaTime*5f;
            //elapsedTime += Time.deltaTime;
            //Debug.Log("페이드아웃 중...");
            startpanel.color = color;
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        
        //color.a += Time.deltaTime * 500f;
        //Debug.Log("페이드아웃 끝");
        onCompleteCallback?.Invoke();
        //yield break;
    }
    public void startbuttonclick()
    {
        isStart = true;
        startobject.SetActive(true);
        StartCoroutine(startFadeOut());
    }
}
