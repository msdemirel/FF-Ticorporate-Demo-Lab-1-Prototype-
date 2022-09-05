using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorStateController : MonoBehaviour
{
    private float speed = 2.0f;
   // public GameObject character;

    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            animator.SetBool("IsWalking", true);
           // transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            animator.SetBool("isWalkingBack", true);
            
        }
        else
        {
            animator.SetBool("IsWalking", false);
        }
    }
}
