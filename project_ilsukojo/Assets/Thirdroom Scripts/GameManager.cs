using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    static public int cardNum;

    int lastNum = 0;

    int cardCnt;

    int hitCnt = 0;

    static public int stageNum = 1;

    //int stageCnt = 6;     // 内靛俊 救结辑 林籍贸府

    int[] arCards = new int[50];

    float startTime;

    float stageTime;

    public enum STATE
    {
        START, HIT, WAIT, IDLE, CLEAR
    };

    static public STATE state = STATE.START;

    // Start is called before the first frame update
    void Start()
    {
        startTime = stageTime = Time.time;
        //StartCoroutine(MakeStage());
    }

    // Update is called once per frame
    void Update()
    {
        switch(state)
        {
            case STATE.START:
                StartCoroutine(MakeStage());
                break;

                case STATE.HIT:

                CheckCard();
                break;

            case STATE.CLEAR:
                StartCoroutine(StageClear());
                break;
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
           Application.Quit();
        }
    }

    void CheckCard()
    {
        state = STATE.WAIT;

        if(lastNum == 0)
        {
            lastNum = cardNum;
            state = STATE.IDLE;
            return;
        }

        int img1 = (cardNum + 1) / 2;
        int img2 = (lastNum + 1) / 2;

        if(img1 !=  img2)
        {
            StartCoroutine(CloseTwoCards());

            lastNum = 0;
            state = STATE.IDLE;
            return;
        }

        hitCnt += 2;

        if(hitCnt == cardCnt)
        {
            state = STATE.CLEAR;
            return;
        }

        lastNum = 0;
        state = STATE.IDLE;
    }

    IEnumerator CloseTwoCards()
    {
        GameObject card1 = GameObject.FindWithTag("card" + lastNum);
        GameObject card2 = GameObject.FindWithTag("card" + cardNum);

        yield return new WaitForSeconds(0.2f);
        card1.SendMessage("CloseCard",SendMessageOptions.DontRequireReceiver);
        card2.SendMessage("CloseCard", SendMessageOptions.DontRequireReceiver);
    }

    IEnumerator StageClear()
    {
        state = STATE.WAIT;

        yield return new WaitForSeconds(2);

        for(int i = 0; i < cardCnt; i++)
        {
            GameObject card = GameObject.FindWithTag("card" + i);
            Destroy(card);
        }
        /*
        ++stageNum;
        if(stageNum > stageCnt)
        {

        }
        stageTime = Time.time;
        lastNum = 0;
        hitCnt = 0;

        state = STATE.START;
        */
    }
        
    IEnumerator MakeStage()
    {

        state = STATE.WAIT;

        float sx = 0;
        float sz = 0;

        SetCardPos(out sx, out sz);

        ShuffleCard();

        int n = 1;
        string[] str = StageSet.stage[stageNum - 1];

        foreach(string t in str)
        {
            char[] ch = t.Trim().ToCharArray();
            float x = sx;

            foreach(char c in ch)
            {
                switch(c)
                {
                    case '*':
                        GameObject card = Instantiate(Resources.Load("Prefab/Card")) as GameObject;

                        card.transform.position = new Vector3(x, 0, sz);

                        //card.tag = "card" + n++;
                        card.tag = "card" + arCards[n++];
                        x++;
                        break;

                    case '.':
                        x++;
                        break;

                    case '>':
                        x += 0.5f;
                        break;

                    case '^':
                        sz += 0.5f;
                        break;
                }
                if(c == '*')
                {
                    yield return new WaitForSeconds(0.03f);
                }
            }

            sz--;
        }
        state = STATE.IDLE;
    }

    void SetCardPos(out float sx, out float sz)
    {
        float x = 0;
        float z = 0;
        float maxX = 0;
        cardCnt = 0;
        string[]str = StageSet.stage[stageNum - 1]; 

        for(int i=0; i<str.Length; i++)
        {
            string t = str[i].Trim();
            x = 0;

            for(int j =0; j<t.Length; j++)
            {
                switch(t[j])
                {
                    case '.':
                    case '*':

                        x++;
                        if (t[j] == '*')
                        {
                            cardCnt++;
                        }
                        break;
                        case '>':
                        x += 0.5f;
                        break;
                    case '^':
                        z -= 0.5f;
                        break;
                }
            }
            if(x > maxX)
            {
                maxX = x;
            }
            z++;
        }
        sx = -maxX / 2;
        sz = (z - 1) / 2;
    }

    void ShuffleCard()
    {
        for(int i = 1; i<= cardCnt; i++)
        {
            arCards[i] = i;
        }

        for(int i = 1; i<=15; i++)
        {
            int n1 = Random.Range(1, cardCnt + 1);
            int n2 = Random.Range(1, cardCnt + 1);

            int t = arCards[n1];
            arCards[n1] = arCards[n2];
            arCards[n2] = t;
        }
    }
            
}
