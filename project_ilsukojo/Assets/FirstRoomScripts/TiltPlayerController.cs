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
    int count1, count2, count3, count4 = 0;
    Vector2 rePos;

    private void Start()
    {
        Player = GameObject.Find("TiltPlayer");
        tiltPlayer = Player.GetComponent<tiltPlayer>();
        hole = GameObject.Find("TiltHole");
        rePos = Player.transform.position;
        
    }

    public void Select()
    {
        if(gameObject.name == "TiltLeft")
        {
            if (tiltPlayer.isMoving == true)
                return;
            tiltPlayer.isMoving = true;
            tiltPlayer.moveDirection = new Vector2(-0.03f, 0f);
            count1++;
            clickNum.text = count1.ToString();
        }

        if (gameObject.name == "TiltUp")
        {
            if (tiltPlayer.isMoving == true)
                return;

            tiltPlayer.isMoving = true;
            tiltPlayer.moveDirection = new Vector2(0f, 0.025f);
            count2++;
            clickNum.text = count2.ToString();
        }

        if (gameObject.name == "TiltDown")
        {
            if (tiltPlayer.isMoving == true)
                return;

            tiltPlayer.isMoving = true;
            tiltPlayer.moveDirection = new Vector2(0f, -0.025f);
            count3++;
            clickNum.text = count3.ToString();
        }

        if (gameObject.name == "TiltRight")
        {
            if (tiltPlayer.isMoving == true)
                return;

            tiltPlayer.isMoving = true;
            tiltPlayer.moveDirection = new Vector2(0.03f, 0f);
            count4++;
            clickNum.text = count4.ToString();
        }

        if (gameObject.name == "TiltRe")
        {
            if (tiltPlayer.isMoving == true)
                return;

            Rigidbody2D rb = tiltPlayer.GetComponent<Rigidbody2D>();
            //rb.position = new Vector2(3.42f, 9.98f);
            rb.position = rePos;

            hole.SetActive(true);
        }
    }

}
