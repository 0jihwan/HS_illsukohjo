using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class knifeController : MonoBehaviour
{

    public GameObject knifeGenerator;
    

    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }
   
    void OnCollisionEnter(Collision other)
    {
        GetComponent<Rigidbody>().isKinematic = true;

      
        
        if (other.gameObject.tag == "terrain")
        {
            Destroy(gameObject);
        }
        

       

    }

    

    void Start()
    {
        Application.targetFrameRate = 60;

        //Shoot(new Vector3(2000, 200, 0));
    }

   
}
