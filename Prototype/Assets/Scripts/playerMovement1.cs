using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement1 : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 2f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;
    Animator anim;


    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    private Vector3 moveDirection = Vector3.zero;

    Vector3 velocity;
    bool isGrounded;


    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);
        if (isGrounded)
        {
            if (moveDirection != Vector3.zero && !Input.GetKey(KeyCode.S))
            {
                Walk();
            }
            else if (moveDirection != Vector3.zero && Input.GetKey(KeyCode.LeftShift))
            {
                Run();
            }
            else if (moveDirection == Vector3.zero)
            {
                Idle();
            }
            moveDirection *= speed;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Jump();
            }

        }
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;
        

        controller.Move(velocity * Time.deltaTime);

       
    }
    private void Walk()
    {
        anim.SetBool("isWalkingBack", true);
        anim.SetBool("isIdle", false);


    }
    private void Run()
    {

    }
    private void Idle()
    {

    }
    private void Jump()
    {

    }
}