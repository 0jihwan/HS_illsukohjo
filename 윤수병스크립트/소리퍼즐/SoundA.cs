using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SoundA : MonoBehaviour
{
    public GameObject Sound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void A()
    {
        GetComponent<SoundState>().a = 1f;
        Sound.SetActive(false);
        Sound.SetActive(true);
    }
}
