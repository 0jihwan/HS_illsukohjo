using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cshFadeController : MonoBehaviour
{
    public bool isFadeIn;   // true - FadeIn, false - Fadeout
    public GameObject panel;
    private Action onCompleteCallback;  //Fade 다음에 진행할 함수
    public GameObject startobject;
    private Image startpanel;
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
            panel.SetActive(true);
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
        Image panelImage = panel.GetComponent<Image>();

        while (elapsedTime < fadedTime)
        {
            float alpha = Mathf.Lerp(1f, 0.3f, elapsedTime / fadedTime);
            Color color = panelImage.color;
            color.a = alpha;
            panelImage.color = color;

            elapsedTime += Time.deltaTime;
            yield return null;
        }

        onCompleteCallback?.Invoke();   // 이후에 해야 하는 액션이 있는 경우 진행한다
    }

    IEnumerator CoFadeOut() // 원래대로 돌아오기
    {
        float elapsedTime = 0f;
        float fadedTime = 2.5f;
        Image panelImage = panel.GetComponent<Image>();

        while (elapsedTime < fadedTime)
        {
            float alpha = Mathf.Lerp(0.3f, 1f, elapsedTime / fadedTime);
            Color color = panelImage.color;
            color.a = alpha;
            panelImage.color = color;

            elapsedTime += Time.deltaTime;
            yield return null;
        }

        onCompleteCallback?.Invoke();
    }

    public void RegisterCallback(Action callback)
    {
        onCompleteCallback = callback;
    }

    IEnumerator startFadeOut()
    {
        float elapsedTime = 0f;
        float fadedTime = 2.5f;
        Color color = startpanel.color;

        while (elapsedTime < fadedTime)
        {
            color.a = Mathf.Lerp(0f, 1f, elapsedTime / fadedTime);
            startpanel.color = color;
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        onCompleteCallback?.Invoke();
    }

    public void startbuttonclick()
    {
        isStart = true;
        startobject.SetActive(true);
        StartCoroutine(startFadeOut());
    }
}
