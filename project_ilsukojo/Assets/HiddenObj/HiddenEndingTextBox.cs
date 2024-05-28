using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HiddenEndingTextBox : MonoBehaviour
{
    public GameObject TextBox;
    public TMP_Text targetText;
    public TMP_Text targetwho;
    private string[] messages; // ����� �޽��� �迭
    private string[] who;
    private int currentMessageIndex = 0; // ���� �޽��� �ε���
    private Coroutine printingCoroutine;
    //GameObject player;

    public bool isdone = false;
    public static HiddenEndingTextBox Instance;

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
            "���� Ż���� �� ����.\n�� ���� ����� Ŀ�Ǻ��� ���ž߰ھ�",
            "�Ӹ��� ����� �ʹ� �ǰ���..\n�׸��� ���� ������...",
            "......����? ���ڱ� ������ �� ����...",
            ".........��\n��� �� ��ﳵ��.",
            "���� ���ٸ� �� �� ���� ��â������ ���°�\n����� ���л�Ȱ�� �����ߴ�",
            "��� ����� ������ �� ����\n��������� ���ư��� ��",
            "�����̾���.\n������� ����",
            "�װ� �и� �����",
            "ģ������ ���ڸ����� ���ڸ��� �ú�\n���� �������� �;� ����Ѱ��",
            "������ ������ ���ư��� ��\n�� ����� ���ѾƿԴ�",
            "������ �ú�� �ΰ����� ��",
            "�ʹ� ������ ������ ���������� ������\n���� �޼տ��� Į�� ����� �־���",
            "�װ� ������ �޷��Դ�.\n�׸��� ��� �Ͼ��",
            "�ʹ� ��Ȳ���� ������ ���� �� ����� �����",
            "���� ���ٰ� �ؾ� ����, CCTV�� ���� ����̾���\n����ڴ� �ƹ��� ������. ���� �� ���Ҵ�",
            "��ĥ ��\n�������� ������ �Դ�",
            "����ڰ� ���� �� �˾�����, ������ ����� ����ڸ� ��ȯ�ߴ�",
            "������ ��ȯ�� �뺸�� ����ڴ�\n�ٷ� ������",
            "����� ����ڷ� ������ ������ ����\n���� �� �𸣰ڴ� ��ﳪ�� �ʴ´�",
            "�׷� ����� �� ������ �ڸ����� ���������� �ߴ�",
            "������ ������ ����ڶ�� ���� ������\n���� ���� �������� �ʾҴ�",
            "���ָ�(forensic hypnosis)\n���� �ָ����� �˰� �ִ� ���ָ���",
            "�ָ��� �������� Ȱ���� ���˼��� ����̴�",
            "�ְ����� �ð������� �����\n�����ڰ� �ƴ�, ����ڿ��Ը� ����Ǵ� ���ָ���",
            "������ ������ ���� ����� �ź��� ����\n�ް� �� ���̴�",
            "�źα��� ����, �ƴ� �ź��� ������ ����� �� �����\n�ź��� ���� �״�� ���ָ��� �޾Ҵ�",
            "�׷��� ����� �ź����� �� �ָ��� ���� ��������\n���Դ����������� �۵����� ����",
            "�����ָ�, �����ָ� ��\n���� �ָ��� �ڼ��� ����� ��Ÿ�� �� ����.",
            "���� ���� �����ؾ� �Ѵ�",
            "�ָ鿡�� ����� ����\n���λ���� ������ ����� ����",
            "���ο� ���� �а���\n�󸶳��� �Ǵ� ġ�� ������,",
            "�ƴϸ� ��� ���� ���� ���� ������� ���ܹ�����\n������ ��ź�� �� �λ��� ��� �� ������"
        };
        who = new string[]
        {
            "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", ""
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
            targetwho.text = who[currentMessageIndex - 1];

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
                targetwho.text = who[currentMessageIndex];
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
            playerMove.canMove = true;
            SceneManager.LoadScene("5_Choose");
            enabled = false;
        }
    }
}
