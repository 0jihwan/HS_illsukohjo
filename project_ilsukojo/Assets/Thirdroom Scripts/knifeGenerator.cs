using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class knifeGenerator : MonoBehaviour
{
    public GameObject knifePrefab;
   // public GameObject ST;
   // int score = 0;

    void Start()
    {
        //this.ST = GameObject.Find("ScoreText");
    }

    
    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            GameObject knife = Instantiate(knifePrefab);

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                Vector3 wolrdDir = ray.direction;
            knife.GetComponent<knifeController>().Shoot(wolrdDir.normalized * 2000);

            


            //knife.GetComponent<knifeController>().Shoot(new Vector3(2000, 200, 0));
        }
    }
    /*
    public void ScorePlus()
    {
        score += 10;
        this.ST.GetComponent<Text>().text = "Score : " + score.ToString() + "count";
    }
    */
 
}
