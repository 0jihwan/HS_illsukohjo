using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiltPlayer : MonoBehaviour
{
    public bool isMoving = false;
    public float speed;
    public Vector2 moveDirection;
    private Rigidbody2D rb;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Hole")
        {
            collision.gameObject.SetActive(false);
        }
    }

    private void Start()
    {
        
        rb = gameObject.GetComponent<Rigidbody2D>();
        //Debug.Log(rb.position);
    }

    private void Update()
    {
        if (isMoving)
        {
            Vector2 movement = moveDirection * speed * Time.deltaTime;
            rb.MovePosition(rb.position + movement);
        }


        int layerMask = 1 << LayerMask.NameToLayer("TiltWall");
        RaycastHit2D hit = Physics2D.Raycast(transform.position, moveDirection, 0.5f, layerMask);
        if (hit.collider != null)
        {
            isMoving = false;
        }
    }
}
