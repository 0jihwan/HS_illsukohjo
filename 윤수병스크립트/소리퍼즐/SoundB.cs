using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundB : MonoBehaviour
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
    public void B()
    {
        GetComponent<SoundState>().b = 1f;
        Sound.SetActive(false);
        Sound.SetActive(true);
    }
}
