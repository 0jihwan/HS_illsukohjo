using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Animator m_animator;

    private Vector3 m_velocity;

    private bool m_wasGrounded;
    private bool m_isGrounded = true;

    public float m_moveSpeed = 3.0f;
    public float m_jumpForce = 3.0f;

    void Start()
    {
        m_animator = GetComponent<Animator>();
    }

    void Update()
    {
        m_animator.SetBool("Grounded", m_isGrounded);
        PlayerMove();
        JumpingAndLanding();

        m_wasGrounded = m_isGrounded;
    }
    //
    private void PlayerMove()
    {
        CharacterController controller = GetComponent<CharacterController>();
        float gravity = 20.0f;

        if (controller.isGrounded)
        {
            /* ������ǥ�� ���� �̵�
            m_velocity = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            m_velocity = m_velocity.normalized;
            */
            //ī�޶� �ٶ󺸴� ���� ��������� �̵�
            Vector3 moveDirection = Camera.main.transform.forward * Input.GetAxis("Vertical") // �յ� �̵�
                + Camera.main.transform.right * Input.GetAxis("Horizontal");    // �¿� �̵�
            moveDirection = moveDirection.normalized;

            m_velocity = moveDirection;
            if (Input.GetKey(KeyCode.LeftShift))
            {
                moveDirection *= 2.0f;
            }
            m_animator.SetFloat("MoveSpeed", m_velocity.magnitude);

            if (Input.GetButtonDown("Jump"))
            {
                // ������ �ϴµ� ������ ����(�ذ�Ϸ�)
                moveDirection.y = m_jumpForce;
                m_velocity.y = moveDirection.y;
            }
            else if (m_velocity.magnitude > 0.5)
            {
                // õ��,�ٴ�(x��) �ٶ��� �ʱ�(�ذ�Ϸ�)
                Vector3 targetPos = transform.position + m_velocity;
                targetPos.y = transform.position.y;
                transform.LookAt(targetPos);
            }
            
        }
        m_velocity.y -= gravity * Time.deltaTime;
        controller.Move(m_velocity * m_moveSpeed * Time.deltaTime);
        m_isGrounded = controller.isGrounded;
    }
    //
    private void JumpingAndLanding()
    {
        if (!m_wasGrounded && m_isGrounded)
        {
            m_animator.SetTrigger("Land");
        }

        if (!m_isGrounded && m_wasGrounded)
        {
            
            m_animator.SetTrigger("Jump");
        }
    }

}
