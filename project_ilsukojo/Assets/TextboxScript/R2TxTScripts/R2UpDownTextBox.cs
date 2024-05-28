using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class R2UpDownTextBox : MonoBehaviour
{
    public GameObject TextBox;
    public TMP_Text targetText;
    private string[] messages; // 출력할 메시지 배열
    private int currentMessageIndex = 0; // 현재 메시지 인덱스
    private Coroutine printingCoroutine;
    //GameObject player;

    public bool isdone = false;
    public static R2UpDownTextBox Instance;

    [SerializeField]
    private YSBPlayerMove playerMove;

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
            "어렸을 때 이렇게 벽에 한자 학습벽보가 붙어있던 게 생각난다.",
            "근데 밑에 이건 뭐지? 니은.. 기역..\n........글자가 아니라 그림인가?",
            "한자 밑에 있는 게 힌트가 될 것 같다.\n읽는 순서이거나, 어쩌면 뭔가의 일부분같기도 해.",
            "한자랑 그림을 유심히 살펴보자."
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
            TextBox.SetActive(true); // 텍스트 박스를 활성화
            currentMessageIndex = 0; // 첫 번째 메시지부터 시작
        }
        if (printingCoroutine != null)  //텍스트가 출력 중인 경우
        {
            StopCoroutine(printingCoroutine); // 이미 실행 중인 코루틴을 멈추고
            targetText.text = messages[currentMessageIndex - 1]; // 현재 메시지를 완전히 출력

            printingCoroutine = null;

            if (currentMessageIndex + 1 < messages.Length)
            {
                //currentMessageIndex++; // 다음 메시지로 이동
            }
            /*
            else if (currentMessageIndex + 1 >= messages.Length)
            {
                TextBox.SetActive(false);
            }
            */

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
                //player.SetActive(true); // 플레이어 활성화
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
            playerMove.movespeed = 5;
            enabled = false;
        }
    }
}
