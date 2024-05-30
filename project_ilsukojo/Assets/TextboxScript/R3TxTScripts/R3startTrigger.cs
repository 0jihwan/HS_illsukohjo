using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R3startTrigger : MonoBehaviour
{
    float timer;
    int startTime = 2;
    [SerializeField]
    private SC_FPSController playerMove;

    void Start()
    {
        timer = 0f;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > startTime)
        {
            // 텍스트 표시 후 코루틴을 시작하여 텍스트 표시가 완료될 때까지 대기
            StartCoroutine(DisplayTextAndEnableMovement());
            enabled = false;  // Update 루프 중단
        }
    }

    private IEnumerator DisplayTextAndEnableMovement()
    {
        playerMove.canMove = false;
        // 텍스트 표시
        R3startTextBox.Instance.PlayText();

        // 텍스트가 완료될 때까지 대기
        while (!R3startTextBox.Instance.isdone)
        {
            yield return null;  // 한 프레임 대기
        }

        // 플레이어 이동 활성화
        playerMove.canMove = true;

        // 트리거 비활성화
        gameObject.SetActive(false);
    }
}
