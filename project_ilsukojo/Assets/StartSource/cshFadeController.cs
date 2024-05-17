using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cshFadeController : MonoBehaviour
{
    public bool isFadeIn;   // true - FadeIn, false - Fadeout
    public GameObject panel;
    private Action onCompleteCallback;  //Fade ������ ������ �Լ�
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
        Debug.Log("���̵�ƿ� ����");
        StartCoroutine(CoFadeOut());
        Debug.Log("���̵�ƿ� ��");
    }

    IEnumerator CoFadeIn()  //���������ٰ�
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

        onCompleteCallback?.Invoke();   // ���Ŀ� �ؾ� �ϴ� �׼��� �ִ� ��� �����Ѵ�
    }

    IEnumerator CoFadeOut() // ������� ���ƿ���
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
