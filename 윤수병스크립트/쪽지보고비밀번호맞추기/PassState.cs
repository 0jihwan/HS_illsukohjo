using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static SoundState;

public class PassState : MonoBehaviour
{
    public GameObject Pa1; 
    public GameObject Pa2;
    public GameObject Pa3;
    public GameObject Pa4;
    public GameObject Pa5;
    public float a, b, c, d, e = 0f;
    public GameObject Result;
    public enum Pastate
    {
        Start,
        s_one,
        s_two,
        s_three,
        s_four,
        sFinal,       
    }
    public Pastate state;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (state == Pastate.Start)
        {
            Pa1.transform.GetChild(0).gameObject.SetActive(true);
            Pa1.transform.GetChild(1).gameObject.SetActive(false);
            Pa1.transform.GetChild(2).gameObject.SetActive(false);
            Pa1.transform.GetChild(3).gameObject.SetActive(false);
            Pa1.transform.GetChild(4).gameObject.SetActive(false);
            Pa1.transform.GetChild(5).gameObject.SetActive(false);
            Pa1.transform.GetChild(6).gameObject.SetActive(false);
            Pa1.transform.GetChild(7).gameObject.SetActive(false);
            Pa1.transform.GetChild(8).gameObject.SetActive(false);
            Pa1.transform.GetChild(9).gameObject.SetActive(false);
            Pa2.transform.GetChild(0).gameObject.SetActive(true);
            Pa2.transform.GetChild(1).gameObject.SetActive(false);
            Pa2.transform.GetChild(2).gameObject.SetActive(false);
            Pa2.transform.GetChild(3).gameObject.SetActive(false);
            Pa2.transform.GetChild(4).gameObject.SetActive(false);
            Pa2.transform.GetChild(5).gameObject.SetActive(false);
            Pa2.transform.GetChild(6).gameObject.SetActive(false);
            Pa2.transform.GetChild(7).gameObject.SetActive(false);
            Pa2.transform.GetChild(8).gameObject.SetActive(false);
            Pa2.transform.GetChild(9).gameObject.SetActive(false);
            Pa3.transform.GetChild(0).gameObject.SetActive(true);
            Pa3.transform.GetChild(1).gameObject.SetActive(false);
            Pa3.transform.GetChild(2).gameObject.SetActive(false);
            Pa3.transform.GetChild(3).gameObject.SetActive(false);
            Pa3.transform.GetChild(4).gameObject.SetActive(false);
            Pa3.transform.GetChild(5).gameObject.SetActive(false);
            Pa3.transform.GetChild(6).gameObject.SetActive(false);
            Pa3.transform.GetChild(7).gameObject.SetActive(false);
            Pa3.transform.GetChild(8).gameObject.SetActive(false);
            Pa3.transform.GetChild(9).gameObject.SetActive(false);
            Pa4.transform.GetChild(0).gameObject.SetActive(true);
            Pa4.transform.GetChild(1).gameObject.SetActive(false);
            Pa4.transform.GetChild(2).gameObject.SetActive(false);
            Pa4.transform.GetChild(3).gameObject.SetActive(false);
            Pa4.transform.GetChild(4).gameObject.SetActive(false);
            Pa4.transform.GetChild(5).gameObject.SetActive(false);
            Pa4.transform.GetChild(6).gameObject.SetActive(false);
            Pa4.transform.GetChild(7).gameObject.SetActive(false);
            Pa4.transform.GetChild(8).gameObject.SetActive(false);
            Pa4.transform.GetChild(9).gameObject.SetActive(false);
            Pa5.transform.GetChild(0).gameObject.SetActive(true);
            Pa5.transform.GetChild(1).gameObject.SetActive(false);
            Pa5.transform.GetChild(2).gameObject.SetActive(false);
            Pa5.transform.GetChild(3).gameObject.SetActive(false);
            Pa5.transform.GetChild(4).gameObject.SetActive(false);
            Pa5.transform.GetChild(5).gameObject.SetActive(false);
            Pa5.transform.GetChild(6).gameObject.SetActive(false);
            Pa5.transform.GetChild(7).gameObject.SetActive(false);
            Pa5.transform.GetChild(8).gameObject.SetActive(false);
            Pa5.transform.GetChild(9).gameObject.SetActive(false);
        }
        if (state == Pastate.sFinal)
        {
            if ((a == 4f) && (b == 2f) && (c == 6f) && (d == 8f) && (e == 9f))
            {
                Pa1.gameObject.SetActive(false);
                Pa2.gameObject.SetActive(false);
                Pa3.gameObject.SetActive(false);
                Pa4.gameObject.SetActive(false);
                Pa5.gameObject.SetActive(false);
                Result.transform.GetChild(1).gameObject.SetActive(true);
            }
            else if (!(a == 4f) || !(b == 2f) || !(c == 6f) || !(d == 8f) || !(e == 9f))
            {
                Pa1.gameObject.SetActive(false);
                Pa2.gameObject.SetActive(false);
                Pa3.gameObject.SetActive(false);
                Pa4.gameObject.SetActive(false);
                Pa5.gameObject.SetActive(false);
                Result.transform.GetChild(0).gameObject.SetActive(true);
                Invoke("Reset", 0.1f);
                Invoke("PaON", 0.5f);
            }
        }

    }
    public void PaON()
    {
        Pa1.gameObject.SetActive(true);
        Pa2.gameObject.SetActive(true);
        Pa3.gameObject.SetActive(true);
        Pa4.gameObject.SetActive(true);
        Pa5.gameObject.SetActive(true);
        Result.transform.GetChild(0).gameObject.SetActive(false);
    }
    public void Reset()
    {
        state = Pastate.Start;
    }
    public void PaOne ()
    {
        if (state == Pastate.Start)
        {
            Pa1.transform.GetChild(1).gameObject.SetActive(true);
            state = Pastate.s_one;
            a = 1f;
        }
        else if (state == Pastate.s_one)
        {
            Pa2.transform.GetChild(1).gameObject.SetActive(true);
            state = Pastate.s_two;
            b = 1f;
        }
        else if (state == Pastate.s_two)
        {
            Pa3.transform.GetChild(1).gameObject.SetActive(true);
            state = Pastate.s_three;
            c = 1f;
        }
        else if (state == Pastate.s_three)
        {
            Pa4.transform.GetChild(1).gameObject.SetActive(true);
            state = Pastate.s_four;
            d = 1f;
        }
        else if (state == Pastate.s_four)
        {
            Pa5.transform.GetChild(1).gameObject.SetActive(true);
            state = Pastate.sFinal;
            e = 1f;
        }
    }
    public void PaTwo () 
    {
        if (state == Pastate.Start)
        {
            Pa1.transform.GetChild(2).gameObject.SetActive(true);
            state = Pastate.s_one;
            a = 2f;
        }
        else if (state == Pastate.s_one)
        {
            Pa2.transform.GetChild(2).gameObject.SetActive(true);
            state = Pastate.s_two;
            b = 2f;
        }
        else if (state == Pastate.s_two)
        {
            Pa3.transform.GetChild(2).gameObject.SetActive(true);
            state = Pastate.s_three;
            c = 2f;
        }
        else if (state == Pastate.s_three)
        {
            Pa4.transform.GetChild(2).gameObject.SetActive(true);
            state = Pastate.s_four;
            d = 2f;
        }
        else if (state == Pastate.s_four)
        {
            Pa5.transform.GetChild(2).gameObject.SetActive(true);
            state = Pastate.sFinal;
            e = 2f;
        }
    }
    public void PaThree () 
    {
        if (state == Pastate.Start)
        {
            Pa1.transform.GetChild(3).gameObject.SetActive(true);
            state = Pastate.s_one;
            a = 3f;
        }
        else if (state == Pastate.s_one)
        {
            Pa2.transform.GetChild(3).gameObject.SetActive(true);
            state = Pastate.s_two;
            b = 3f;
        }
        else if (state == Pastate.s_two)
        {
            Pa3.transform.GetChild(3).gameObject.SetActive(true);
            state = Pastate.s_three;
            c = 3f;
        }
        else if (state == Pastate.s_three)
        {
            Pa4.transform.GetChild(3).gameObject.SetActive(true);
            state = Pastate.s_four;
            d = 3f;
        }
        else if (state == Pastate.s_four)
        {
            Pa5.transform.GetChild(3).gameObject.SetActive(true);
            state = Pastate.sFinal;
            e = 3f;
        }
    }
    public void PaFour() {
        if (state == Pastate.Start)
        {
            Pa1.transform.GetChild(4).gameObject.SetActive(true);
            state = Pastate.s_one;
            a = 4f;
        }
        else if (state == Pastate.s_one)
        {
            Pa2.transform.GetChild(4).gameObject.SetActive(true);
            state = Pastate.s_two;
            b = 4f;
        }
        else if (state == Pastate.s_two)
        {
            Pa3.transform.GetChild(4).gameObject.SetActive(true);
            state = Pastate.s_three;
            c = 4f;
        }
        else if (state == Pastate.s_three)
        {
            Pa4.transform.GetChild(4).gameObject.SetActive(true);
            state = Pastate.s_four;
            d = 4f;
        }
        else if (state == Pastate.s_four)
        {
            Pa5.transform.GetChild(4).gameObject.SetActive(true);
            state = Pastate.sFinal;
            e = 4f;
        }
    }
    public void PaFive() {
        if (state == Pastate.Start)
        {
            Pa1.transform.GetChild(5).gameObject.SetActive(true);
            state = Pastate.s_one;
            a = 5f;
        }
        else if (state == Pastate.s_one)
        {
            Pa2.transform.GetChild(5).gameObject.SetActive(true);
            state = Pastate.s_two;
            b = 5f;
        }
        else if (state == Pastate.s_two)
        {
            Pa3.transform.GetChild(5).gameObject.SetActive(true);
            state = Pastate.s_three;
            c = 5f;
        }
        else if (state == Pastate.s_three)
        {
            Pa4.transform.GetChild(5).gameObject.SetActive(true);
            state = Pastate.s_four;
            d = 5f;
        }
        else if (state == Pastate.s_four)
        {
            Pa5.transform.GetChild(5).gameObject.SetActive(true);
            state = Pastate.sFinal;
            e = 5f;
        }
    }
    public void PaSix() {
        if (state == Pastate.Start)
        {
            Pa1.transform.GetChild(6).gameObject.SetActive(true);
            state = Pastate.s_one;
            a = 6f;
        }
        else if (state == Pastate.s_one)
        {
            Pa2.transform.GetChild(6).gameObject.SetActive(true);
            state = Pastate.s_two;
            b = 6f;
        }
        else if (state == Pastate.s_two)
        {
            Pa3.transform.GetChild(6).gameObject.SetActive(true);
            state = Pastate.s_three;
            c = 6f;
        }
        else if (state == Pastate.s_three)
        {
            Pa4.transform.GetChild(6).gameObject.SetActive(true);
            state = Pastate.s_four;
            d = 6f;
        }
        else if (state == Pastate.s_four)
        {
            Pa5.transform.GetChild(6).gameObject.SetActive(true);
            state = Pastate.sFinal;
            e = 6f;
        }
    }
    public void PaSeven() {
        if (state == Pastate.Start)
        {
            Pa1.transform.GetChild(7).gameObject.SetActive(true);
            state = Pastate.s_one;
            a = 7f;
        }
        else if (state == Pastate.s_one)
        {
            Pa2.transform.GetChild(7).gameObject.SetActive(true);
            state = Pastate.s_two;
            b = 7f;
        }
        else if (state == Pastate.s_two)
        {
            Pa3.transform.GetChild(7).gameObject.SetActive(true);
            state = Pastate.s_three;
            c = 7f;
        }
        else if (state == Pastate.s_three)
        {
            Pa4.transform.GetChild(7).gameObject.SetActive(true);
            state = Pastate.s_four;
            d = 7f;
        }
        else if (state == Pastate.s_four)
        {
            Pa5.transform.GetChild(7).gameObject.SetActive(true);
            state = Pastate.sFinal;
            e = 7f;
        }
    }
    public void PaEight() {
        if (state == Pastate.Start)
        {
            Pa1.transform.GetChild(8).gameObject.SetActive(true);
            state = Pastate.s_one;
            a = 8f;
        }
        else if (state == Pastate.s_one)
        {
            Pa2.transform.GetChild(8).gameObject.SetActive(true);
            state = Pastate.s_two;
            b = 8f;
        }
        else if (state == Pastate.s_two)
        {
            Pa3.transform.GetChild(8).gameObject.SetActive(true);
            state = Pastate.s_three;
            c = 8f;
        }
        else if (state == Pastate.s_three)
        {
            Pa4.transform.GetChild(8).gameObject.SetActive(true);
            state = Pastate.s_four;
            d = 8f;
        }
        else if (state == Pastate.s_four)
        {
            Pa5.transform.GetChild(8).gameObject.SetActive(true);
            state = Pastate.sFinal;
            e = 8f;
        }
    }
    public void PaNine() {
        if (state == Pastate.Start)
        {
            Pa1.transform.GetChild(9).gameObject.SetActive(true);
            state = Pastate.s_one;
            a = 9f;
        }
        else if (state == Pastate.s_one)
        {
            Pa2.transform.GetChild(9).gameObject.SetActive(true);
            state = Pastate.s_two;
            b = 9f;
        }
        else if (state == Pastate.s_two)
        {
            Pa3.transform.GetChild(9).gameObject.SetActive(true);
            state = Pastate.s_three;
            c = 9f;
        }
        else if (state == Pastate.s_three)
        {
            Pa4.transform.GetChild(9).gameObject.SetActive(true);
            state = Pastate.s_four;
            d = 9f;
        }
        else if (state == Pastate.s_four)
        {
            Pa5.transform.GetChild(9).gameObject.SetActive(true);
            state = Pastate.sFinal;
            e = 9f;
        }
    }

}
