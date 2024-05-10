using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class cshTextBox : MonoBehaviour
{
    public GameObject TextBox;
    public TMP_Text targetText;
    private string[] messages; // 출력할 메시지 배열
    private int currentMessageIndex = 0; // 현재 메시지 인덱스
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
        // 메시지 예시
        messages = new string[] {
            "첫 번째 메시지입니다. 클릭하세요.\n 나는 일렉기타다 나는 일렉기타다 나는 일렉기타다 나는 일렉기타다",
            "두 번째 메시지입니다. 클릭하세요.",
            "마지막 메시지입니다. 클릭하면 종료됩니다."
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
            TextBox.SetActive(true); // 텍스트 박스를 활성화
            currentMessageIndex = 0; // 첫 번째 메시지부터 시작
        }
        if (printingCoroutine != null)  //텍스트가 출력 중인 경우
        {
            StopCoroutine(printingCoroutine); // 이미 실행 중인 코루틴을 멈추고
            targetText.text = messages[currentMessageIndex - 1]; // 현재 메시지를 완전히 출력

            printingCoroutine = null;


            
        }
        else    // 텍스트가 이미 다 출력된 경우
        {
            if (currentMessageIndex < messages.Length)
            {
                
                printingCoroutine = StartCoroutine(TextPrintCoroutine(messages[currentMessageIndex]));
                currentMessageIndex++;
            }
            else if (currentMessageIndex + 1 > messages.Length)
            {
                TextBox.SetActive(false); // 모든 메시지 출력 후 텍스트박스 비활성화
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
