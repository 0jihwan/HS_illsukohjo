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
    private string[] messages; // 출력할 메시지 배열
    private string[] who;
    private int currentMessageIndex = 0; // 현재 메시지 인덱스
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
        // 메시지 예시
        messages = new string[] {
            "드디어 탈출인 것 같다.\n이 곳을 벗어나면 커피부터 마셔야겠어",
            "머리를 썼더니 너무 피곤해..\n그리고 다음 면접을...",
            "......면접? 갑자기 면접이 왜 나왔...",
            ".........아\n모든 게 기억났다.",
            "나는 남다를 것 거 없는 학창시절을 보냈고\n평범한 대학생활을 졸업했다",
            "어느 기업의 면접을 잘 보고\n자취방으로 돌아가는 길",
            "살인이었다.\n우발적인 살인",
            "그건 분명 사고였다",
            "친구와의 술자리에서 옆자리의 시비\n좋게 지나가고 싶어 웃어넘겼다",
            "하지만 집으로 돌아가는 길\n그 사람이 뒤쫓아왔다",
            "질나쁜 시비와 인격적인 모독",
            "너무 무서워 조용히 지나가려고 했지만\n그의 왼손에는 칼이 들려져 있었다",
            "그가 나에게 달려왔다.\n그리고 사고가 일어났다",
            "너무 당황스런 나머지 나는 그 골목을 벗어났다",
            "운이 좋다고 해야 될지, CCTV가 없는 골목이었고\n목격자는 아무도 없었다. 없는 것 같았다",
            "며칠 뒤\n경찰에서 연락이 왔다",
            "목격자가 없는 줄 알았지만, 경찰은 사건의 목격자를 소환했다",
            "경찰이 소환을 통보한 목격자는\n바로 나였다",
            "사건의 목격자로 오인한 경찰에 나는\n그저 잘 모르겠다 기억나지 않는다",
            "그런 말들로 이 불편한 자리에서 빠져나오려 했다",
            "하지만 유일한 목격자라는 점에 경찰은\n나를 쉽게 놓아주지 않았다",
            "법최면(forensic hypnosis)\n흔히 최면수사로 알고 있는 법최면은",
            "최면을 법적으로 활용한 범죄수사 기법이다",
            "주관적인 시각에서의 수사라\n용의자가 아닌, 목격자에게만 시행되는 법최면을",
            "수사의 진전을 위해 목격자 신분인 내가\n받게 된 것이다",
            "거부권이 없는, 아니 거부할 이유가 없어야 할 목격자\n신분인 나는 그대로 법최면을 받았다",
            "그러나 목격자 신분으로 건 최면은 실은 가해자인\n내게는정상적으로 작동하지 못해",
            "전생최면, 교육최면 등\n여러 최면이 뒤섞인 모습이 나타난 것 같다.",
            "이제 나는 선택해야 한다",
            "최면에서 깨어나면 나는\n살인사건의 범인이 나라고 밝혀",
            "살인에 대한 죗값을\n얼마나가 되던 치를 것인지,",
            "아니면 모든 것을 숨겨 미제 사건으로 남겨버리고\n이제는 순탄할 내 인생을 계속 살 것인지"
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
            playerMove.canMove = true;
            SceneManager.LoadScene("5_Choose");
            enabled = false;
        }
    }
}
