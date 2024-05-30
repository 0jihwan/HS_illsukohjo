using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class R3startTextBox : MonoBehaviour
{
    public GameObject TextBox;
    public TMP_Text targetText;
    private string[] messages; // ����� �޽��� �迭
    private int currentMessageIndex = 0; // ���� �޽��� �ε���
    private Coroutine printingCoroutine;
    //GameObject player;

    public bool isdone = false;
    public static R3startTextBox Instance;

    [SerializeField]
    private SC_FPSController playerMove;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        // �޽��� ����
        messages = new string[] {
            "�̹� ���� �������� �� ���� ����� ���.",
            "�׸�ŭ ���� ���� �� ����.\n�ֺ��� �� �����غ���."
        };
    }

    void Start()
    {
        TextBox.SetActive(false);
        //player = GameObject.FindWithTag("Player");
    }

    public void PlayText()
    {
        if (TextBox.activeSelf == false)
        {
            TextBox.SetActive(true); // �ؽ�Ʈ �ڽ��� Ȱ��ȭ
            currentMessageIndex = 0; // ù ��° �޽������� ����
        }
        if (printingCoroutine != null)  //�ؽ�Ʈ�� ��� ���� ���
        {
            StopCoroutine(printingCoroutine); // �̹� ���� ���� �ڷ�ƾ�� ���߰�
            targetText.text = messages[currentMessageIndex - 1]; // ���� �޽����� ������ ���

            printingCoroutine = null;

            if (currentMessageIndex + 1 < messages.Length)
            {
                //currentMessageIndex++; // ���� �޽����� �̵�
            }
            /*
            else if (currentMessageIndex + 1 >= messages.Length)
            {
                TextBox.SetActive(false);
            }
            */

        }
        else    // �ؽ�Ʈ�� �̹� �� ��µ� ���
        {
            if (currentMessageIndex < messages.Length)
            {

                printingCoroutine = StartCoroutine(TextPrintCoroutine(messages[currentMessageIndex]));
                currentMessageIndex++;
            }
            else if (currentMessageIndex + 1 > messages.Length)
            {
                TextBox.SetActive(false); // ��� �޽��� ��� �� �ؽ�Ʈ�ڽ� ��Ȱ��ȭ
                //player.SetActive(true); // �÷��̾� Ȱ��ȭ
                isdone = true;

            }
        }
        //currentMessageIndex++;
    }

    IEnumerator TextPrintCoroutine(string message)
    {
        targetText.text = "";
        foreach (char c in message)
        {
            targetText.text += c;
            yield return new WaitForSeconds(0.05f);
        }
        printingCoroutine = null;
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) && TextBox.activeSelf)
        {
            PlayText();
        }
        else if (!TextBox.activeSelf && isdone)
        {
            //playerMove.canMove = false;
            enabled = false;
        }
    }
}
