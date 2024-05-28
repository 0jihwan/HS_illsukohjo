using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chooseButtonManager : MonoBehaviour
{
    public GameObject button1;
    public GameObject button2;
    // Start is called before the first frame update
    public void jabaekhanda()
    {
        jabaek.Instance.PlayText();
        Destroy(button1);
        Destroy(button2);
    }
    public void soomginda()
    {
        hide.Instance.PlayText();
        Destroy(button1);
        Destroy(button2);
    }
}
