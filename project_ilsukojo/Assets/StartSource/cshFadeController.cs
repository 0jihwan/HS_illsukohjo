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
    private Action onCompleteCallback;  //Fade ������ ������ �Լ�
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
        Debug.Log("���̵�ƿ� ����");
        StartCoroutine(CoFadeOut());
        Debug.Log("���̵�ƿ� ��");
    }
    IEnumerator CoFadeIn()  //���������ٰ�
    {
        float elapsedTime = 0f;
        float fadedTime = 2.5f;

        while(elapsedTime < fadedTime) { 
            panel.GetComponent<CanvasRenderer>().SetAlpha(Mathf.Lerp(1f, 0.3f, elapsedTime/fadedTime));
            elapsedTime += Time.deltaTime;
            //Debug.Log("���̵��� ��...");
            yield return null;
        }
        //Debug.Log("���̵��� ��");
        //panel.SetActive(false); //panel ��Ȱ��ȭ
        onCompleteCallback?.Invoke();   // ���Ŀ� �ؾ� �ϴ� �׼��� �ִ� ��� �����Ѵ�
        yield break;
    }
    IEnumerator CoFadeOut() // ������� ���ƿ���
    {
        float elapsedTime = 0f;
        float fadedTime = 2.5f;

        while(elapsedTime <= fadedTime)
        {
            panel.GetComponent<CanvasRenderer>().SetAlpha(Mathf.Lerp(0.3f, 1f, elapsedTime / fadedTime));
            elapsedTime += Time.deltaTime;
            //Debug.Log("���̵�ƿ� ��...");
            yield return null;
        }
        //Debug.Log("���̵�ƿ� ��");
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
            //Debug.Log("���̵�ƿ� ��...");
            startpanel.color = color;
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        
        //color.a += Time.deltaTime * 500f;
        //Debug.Log("���̵�ƿ� ��");
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
