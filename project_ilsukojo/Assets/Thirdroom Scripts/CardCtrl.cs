using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardCtrl : MonoBehaviour
{
    int imgNum = 1;

    int backNum = 1;

    bool isOpen = false;

    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            CheckCard();
        }
    }

    void CheckCard()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);  
        
        if(Physics.Raycast(ray, out hit,Mathf.Infinity) )
        {
            string tag = hit.transform.tag;
            if(tag.Substring(0,4) == "card")
            {
                hit.transform.SendMessage("OpenCard", SendMessageOptions.DontRequireReceiver);
            }
        }
    }

    void OpenCard()
    {
        if (isOpen) return;
        isOpen = true;

        int cardNum = int.Parse(transform.tag.Substring(4));

        imgNum = (cardNum + 1) / 2;
        anim.Play("aniOpen");

        GameManager.cardNum = cardNum;
        GameManager.state = GameManager.STATE.HIT;
    }

    void CloseCard()
    {
        anim.Play("aniClose");
        isOpen = false;
    }

    void ShowImage()
    {
        transform.GetComponent<Renderer>().material.mainTexture = Resources.Load("card" + imgNum) as Texture2D;
    }
    void HideImage()
    {
        transform.GetComponent<Renderer>().material.mainTexture = Resources.Load("back" + backNum) as Texture2D;
    }
}
