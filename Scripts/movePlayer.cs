using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class movePlayer : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    private Vector2 moveVector;
    private Animator anim;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {

        if(Input.GetKey(KeyCode.A)){
            moveVector.x = -1;
        }
        else if(Input.GetKey(KeyCode.D)){
            moveVector.x = 1;
        }
        else{
            moveVector.x = 0;
        }

        if(Input.GetKey(KeyCode.W)){
            moveVector.y = 1;
        }
        else if(Input.GetKey(KeyCode.S)){
            moveVector.y = -1;
        }
        else{
            moveVector.y = 0;
        }
        

        rb.MovePosition(rb.position + moveVector.normalized * speed * Time.deltaTime);
        if(moveVector.x == 0 && moveVector.y == 0){anim.SetBool("isRunning", false);}
        else
        {
            anim.SetBool("isRunning", true);
            if(moveVector.x > 0){
                anim.SetBool("isRunningRight", true);
            }
            else{anim.SetBool("isRunningRight", false);}


            if(moveVector.y > 0){
                anim.SetBool("isRunningUp", true);
            }
            else{anim.SetBool("isRunningUp", false);}


            if(moveVector.x < 0){
                anim.SetBool("isRunningLeft", true);
            }
            else{anim.SetBool("isRunningLeft", false);}

            
            if(moveVector.y < 0){
                anim.SetBool("isRunningDown", true);
            }
            else{anim.SetBool("isRunningDown", false);}
        }
        }
    }
