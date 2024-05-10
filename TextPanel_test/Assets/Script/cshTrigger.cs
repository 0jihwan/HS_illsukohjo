using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshTrigger : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Event"))
        {

            Debug.Log("Event triggered!");
            cshTextBox.Instance.PlayText();
          
        }
    }
}
