using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class cshTextBox : MonoBehaviour
{
    public GameObject TextBox;
    public TMP_Text targetText;
    private string[] messages; // ����� �޽��� �迭
    private int currentMessageIndex = 0; // ���� �޽��� �ε���
    private Coroutine printingCoroutine;

    public static cshTextBox Instance;

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
            "ù ��° �޽����Դϴ�. Ŭ���ϼ���.\n ���� �Ϸ���Ÿ�� ���� �Ϸ���Ÿ�� ���� �Ϸ���Ÿ�� ���� �Ϸ���Ÿ��",
            "�� ��° �޽����Դϴ�. Ŭ���ϼ���.",
            "������ �޽����Դϴ�. Ŭ���ϸ� ����˴ϴ�."
        };
    }

    void Start()
    {
        TextBox.SetActive(false);
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
            }
        }
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
        if (Input.GetMouseButtonDown(0) && TextBox.activeSelf)
        {
            PlayText();
        }
    }
}
