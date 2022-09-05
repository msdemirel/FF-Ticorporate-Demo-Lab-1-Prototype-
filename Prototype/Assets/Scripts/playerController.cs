using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float turnSpeed = 50f;
    Animator anim;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {


         if(Input.GetKey(KeyCode.S))
        {
            anim.SetBool("isWalkingBack", true);
            anim.SetBool("isIdle", false);
            
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);


        }
       

        else if(Input.GetKey(KeyCode.W))
        {
            anim.SetBool("isWalking", true);
            anim.SetBool("isIdle", false);
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);




        }
      
        else if(Input.GetKey(KeyCode.A))
        {
            anim.SetBool("isTurning", true);
            anim.SetBool("isIdle", false);
            transform.Rotate(0.0f, -1.0f, 0.0f, Space.Self);



        }
        else if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("isTurningRight", true);
            anim.SetBool("isIdle", false);
            transform.Rotate(0.0f, 1.0f, 0.0f, Space.Self);



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
