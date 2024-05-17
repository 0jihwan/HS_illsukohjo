using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TiltPlayerController : MonoBehaviour
{
    GameObject Player;
    tiltPlayer tiltPlayer;
    GameObject hole;
    public TMP_Text clickNum;
    int count = 0;
    Vector2 rePos;

    public bool currentSelect = false;
    GameObject tiltBtn;
    TiltPlayerController tiltPC;

    private void Start()
    {
        Player = GameObject.Find("TiltPlayer");
        tiltPlayer = Player.GetComponent<tiltPlayer>();
        hole = GameObject.Find("TiltHole");
        rePos = Player.transform.position;
    }

    public void Select()
    {
        if (currentSelect)
        {
            return;
        }
        if (gameObject.name == "TiltLeft")
        {
            if (tiltPlayer.isMoving == true)
                return;
          
            tiltPlayer.isMoving = true;
            tiltPlayer.moveDirection = new Vector2(-0.03f, 0f);
            count++;
            clickNum.text = count.ToString();

            currentSelect = true;

            tiltBtn = GameObject.Find("TiltUp");
            tiltPC = tiltBtn.GetComponent<TiltPlayerController>();
            tiltPC.currentSelect = false;

            tiltBtn = GameObject.Find("TiltDown");
            tiltPC = tiltBtn.GetComponent<TiltPlayerController>();
            tiltPC.currentSelect = false;

            tiltBtn = GameObject.Find("TiltRight");
            tiltPC = tiltBtn.GetComponent<TiltPlayerController>();
            tiltPC.currentSelect = false;

        }

        if (gameObject.name == "TiltUp")
        {
            if (tiltPlayer.isMoving == true)
                return;          

            tiltPlayer.isMoving = true;
            tiltPlayer.moveDirection = new Vector2(0f, 0.025f);
            count++;
            clickNum.text = count.ToString();

            currentSelect = true;

            tiltBtn = GameObject.Find("TiltLeft");
            tiltPC = tiltBtn.GetComponent<TiltPlayerController>();
            tiltPC.currentSelect = false;

            tiltBtn = GameObject.Find("TiltDown");
            tiltPC = tiltBtn.GetComponent<TiltPlayerController>();
            tiltPC.currentSelect = false;

            tiltBtn = GameObject.Find("TiltRight");
            tiltPC = tiltBtn.GetComponent<TiltPlayerController>();
            tiltPC.currentSelect = false;

        }

        if (gameObject.name == "TiltDown")
        {
            if (tiltPlayer.isMoving == true)
                return;

            tiltPlayer.isMoving = true;
            tiltPlayer.moveDirection = new Vector2(0f, -0.025f);
            count++;
            clickNum.text = count.ToString();

            currentSelect = true;

            tiltBtn = GameObject.Find("TiltUp");
            tiltPC = tiltBtn.GetComponent<TiltPlayerController>();
            tiltPC.currentSelect = false;

            tiltBtn = GameObject.Find("TiltLeft");
            tiltPC = tiltBtn.GetComponent<TiltPlayerController>();
            tiltPC.currentSelect = false;

            tiltBtn = GameObject.Find("TiltRight");
            tiltPC = tiltBtn.GetComponent<TiltPlayerController>();
            tiltPC.currentSelect = false;
        }

        if (gameObject.name == "TiltRight")
        {
            if (tiltPlayer.isMoving == true)
                return;

            tiltPlayer.isMoving = true;
            tiltPlayer.moveDirection = new Vector2(0.03f, 0f);
            count++;
            clickNum.text = count.ToString();

            currentSelect = true;

            tiltBtn = GameObject.Find("TiltUp");
            tiltPC = tiltBtn.GetComponent<TiltPlayerController>();
            tiltPC.currentSelect = false;

            tiltBtn = GameObject.Find("TiltDown");
            tiltPC = tiltBtn.GetComponent<TiltPlayerController>();
            tiltPC.currentSelect = false;

            tiltBtn = GameObject.Find("TiltLeft");
            tiltPC = tiltBtn.GetComponent<TiltPlayerController>();
            tiltPC.currentSelect = false;
        }

        if (gameObject.name == "TiltRe")
        {
            if (tiltPlayer.isMoving == true)
                return;

            Rigidbody2D rb = tiltPlayer.GetComponent<Rigidbody2D>();
            //rb.position = new Vector2(3.42f, 9.98f);
            rb.position = rePos;

            hole.SetActive(true);

            tiltBtn = GameObject.Find("TiltUp");
            tiltPC = tiltBtn.GetComponent<TiltPlayerController>();
            tiltPC.currentSelect = false;
            tiltPC.count = 0;
            tiltPC.clickNum.text = tiltPC.count.ToString();

            tiltBtn = GameObject.Find("TiltDown");
            tiltPC = tiltBtn.GetComponent<TiltPlayerController>();
            tiltPC.currentSelect = false;
            tiltPC.count = 0;
            tiltPC.clickNum.text = tiltPC.count.ToString();

            tiltBtn = GameObject.Find("TiltLeft");
            tiltPC = tiltBtn.GetComponent<TiltPlayerController>();
            tiltPC.currentSelect = false;
            tiltPC.count = 0;
            tiltPC.clickNum.text = tiltPC.count.ToString();

            tiltBtn = GameObject.Find("TiltRight");
            tiltPC = tiltBtn.GetComponent<TiltPlayerController>();
            tiltPC.currentSelect = false;
            tiltPC.count = 0;
            tiltPC.clickNum.text = tiltPC.count.ToString();
        }
    }

}
