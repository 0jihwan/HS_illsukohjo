using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class startTextBox : MonoBehaviour
{
    public GameObject TextBox;
    public TMP_Text targetText;
    private string[] messages; // 출력할 메시지 배열
    private int currentMessageIndex = 0; // 현재 메시지 인덱스
    private Coroutine printingCoroutine;
    //GameObject player;
    private bool isdone = false;

    public static startTextBox Instance;


    [SerializeField]
    private PlayerMove playerMove;

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
            "여기는... 어디지...?\n 내가 왜 이런 비좁은 공간에 있는 거야..",
            "저기요! 여기 아무도 없어요?",
            "너무 당황스럽다. 눈떠보니 밀실이라니.. 일단 출구부터 찾아보자",
            "//WASD로 움직이고 좌클릭으로 상호작용할 수 있습니다.//"
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
            playerMove.moveSpeed = 7;
            enabled = false;
        }
    }
}
