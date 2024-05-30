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
            // �ؽ�Ʈ ǥ�� �� �ڷ�ƾ�� �����Ͽ� �ؽ�Ʈ ǥ�ð� �Ϸ�� ������ ���
            StartCoroutine(DisplayTextAndEnableMovement());
            enabled = false;  // Update ���� �ߴ�
        }
    }

    private IEnumerator DisplayTextAndEnableMovement()
    {
        playerMove.canMove = false;
        // �ؽ�Ʈ ǥ��
        R3startTextBox.Instance.PlayText();

        // �ؽ�Ʈ�� �Ϸ�� ������ ���
        while (!R3startTextBox.Instance.isdone)
        {
            yield return null;  // �� ������ ���
        }

        // �÷��̾� �̵� Ȱ��ȭ
        playerMove.canMove = true;

        // Ʈ���� ��Ȱ��ȭ
        gameObject.SetActive(false);
    }
}
