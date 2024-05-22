using System.Collections;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour     // 카메라가 Room2 입구로 이동하는 코드
{
    public CRCameraSwap crCameraSwap;
    public GameObject StartText;
    public CRstartTextBox CRT1;
    public bool isdone = false;

    private Vector3 startPosition = new Vector3(-5, 3, 13);
    private Vector3 targetPosition = new Vector3(61.15f, 8.59f, -33.9f);
    private float transitionDuration = 2.0f; 
    private bool isSwitching = false;
    private int startTime = 4;
    private float timer;

    void Start()
    {
        timer = 0f;
    }
    private void Update()
    {
        timer += Time.deltaTime;
        if (!StartText.activeSelf && !isSwitching && CRT1.isdone)
        {
            Debug.Log("이동!");
            isSwitching = true;
            StartCoroutine(SwitchCameraAndMove());
            timer = 0f;
        }

        if (timer > startTime && isSwitching)
        {
            Debug.Log("시간!");
            isdone = true;
            crCameraSwap.CROnMainPlayer();
            
        }
    }

    private IEnumerator SwitchCameraAndMove()
    {
        crCameraSwap.CROnSubCamera();

        crCameraSwap.subCamera.transform.position = startPosition;

        float elapsedTime = 0f;

        while (elapsedTime < transitionDuration)
        {
            elapsedTime += Time.deltaTime;
            float t = elapsedTime / transitionDuration;
            crCameraSwap.subCamera.transform.position = Vector3.Lerp(startPosition, targetPosition, Mathf.SmoothStep(0f, 1f, t));
            yield return null;
        }

        crCameraSwap.subCamera.transform.position = targetPosition;
    }
}
