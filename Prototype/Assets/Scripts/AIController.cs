using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AIController : MonoBehaviour
{
    
    public Transform Player;
    
    float MoveSpeed = 0.8f;
    int MaxDist = 7;
    int MinDist = 2;
    Animator anim;



    void Start()
    {
        anim = GetComponent<Animator>();

    }

    void Update()
    {
        transform.LookAt(Player);

        if (Vector3.Distance(transform.position, Player.position) >= MinDist)
        {

            transform.position += transform.forward * MoveSpeed * Time.deltaTime;
            anim.SetBool("isWalking", true);
            anim.SetBool("isIdle", false);

        }
        else if  (Vector3.Distance(transform.position, Player.position) <= MaxDist)
        {
            anim.SetBool("isWalking", false);
            anim.SetBool("isIdle", true);
            //Here Call any function U want Like Shoot at here or something
        }

    }
}