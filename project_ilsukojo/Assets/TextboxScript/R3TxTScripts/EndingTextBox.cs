using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingTextBox : MonoBehaviour
{
    public GameObject TextBox;
    public TMP_Text targetText;
    public TMP_Text targetwho;
    private string[] messages; // 출력할 메시지 배열
    private string[] who;
    private int currentMessageIndex = 0; // 현재 메시지 인덱스
    private Coroutine printingCoroutine;
    //GameObject player;

    public bool isdone = false;
    public static EndingTextBox Instance;

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
        // 메시지 예시
        messages = new string[] {
            "드디어 탈출인 것 같다.\n이 곳을 벗어나면 커피부터 마셔야겠어",
            "머리를 썼더니 너무 피곤해..\n으으...",
            "....세요?...........괜찮으세요?\n.....격자 분...",
            "...목격자 분! 정신이 드세요?",
            "어..? 여긴...",
            "휴, 다행입니다.방금 목격자 분\n정신을 차리셨습니다. 법최면 실패입니다.",
            "목격자 분에게 무리가 갈 수 있으니\n법최면은 여기서 종결해야 할 것 같습니다.",
            "목격자..? 법최면?? 이게 무슨...",
            "기억 안나세요?\n살인사건의 유일한 목격자로 소환되셨습니다.",
            "하지만 기억이 없으셔서 수사에서\n금방 제외되실겁니다.",
            "아...그렇구나....하하",
            "그냥, 어째선지\n웃음이 튀어나왔다.",
            ".......집에 가자."
        };
        who = new string[]
        {
            "", "", "???", "경찰", "", "경찰", "최면사", "", "경찰", "경찰", "", "", ""
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
            targetwho.text = who[currentMessageIndex - 1];

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
                targetwho.text = who[currentMessageIndex];
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
            SceneManager.LoadScene("0_Start");
            enabled = false;
        }
    }
}
