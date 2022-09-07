using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float turnSpeed = 50f;
    Animator anim;
    private Vector3 moveDirection = Vector3.zero;
    public CharacterController controller;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
       
    }

    // Update is called once per frame
    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");

        var vertical = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(horizontal, 0, vertical) * (moveSpeed * Time.deltaTime));


        if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("isWalkingBack", true);
            anim.SetBool("isIdle", false);

            //transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));

            moveDirection *= moveSpeed;

        }
       

        else if(Input.GetKey(KeyCode.W))
        {
            anim.SetBool("isWalking", true);
            anim.SetBool("isIdle", false);
            //transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));

            moveDirection *= moveSpeed;


        }
      
        else if(Input.GetKey(KeyCode.A))
        {
            anim.SetBool("isTurning", true);
            anim.SetBool("isIdle", false);
            transform.Rotate(0.0f, -0.3f, 0.0f, Space.Self);

            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));

            moveDirection *= moveSpeed;

        }
        else if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("isTurningRight", true);
            anim.SetBool("isIdle", false);
            transform.Rotate(0.0f, 0.3f, 0.0f, Space.Self);

            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));

            moveDirection *= moveSpeed;

        }
        else
        {

            anim.SetBool("isTurning", false);
            anim.SetBool("isWalkingBack", false);
            anim.SetBool("isWalking", false);
            anim.SetBool("isTurningRight", false);



            anim.SetBool("isIdle", true);

        }



    }


}
