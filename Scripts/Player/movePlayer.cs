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

        if(Pause.isPaused == true){
            return;
        }
        if(Input.GetKey(KeyCode.A)){
            moveVector.x = -1;
            anim.SetBool("isRunning", true);

            anim.SetBool("isRunningLeft", true);
            anim.SetBool("isRunningRight", false);
        }
        else if(Input.GetKey(KeyCode.D)){
            moveVector.x = 1;
            anim.SetBool("isRunning", true);

            anim.SetBool("isRunningRight", true);
            anim.SetBool("isRunningLeft", false);
        }
        else{
            moveVector.x = 0;
            anim.SetBool("isRunningLeft", false);
            anim.SetBool("isRunningRight", false);
        }

        if(Input.GetKey(KeyCode.W)){
            moveVector.y = 1;
            anim.SetBool("isRunning", true);

            anim.SetBool("isRunningUp", true);
            anim.SetBool("isRunningDown", false);

        }
        else if(Input.GetKey(KeyCode.S)){
            moveVector.y = -1;
            anim.SetBool("isRunning", true);

            anim.SetBool("isRunningDown", true);
            anim.SetBool("isRunningUp", false);
        }
        else{
            moveVector.y = 0;
            anim.SetBool("isRunningDown", false);
            anim.SetBool("isRunningUp", false);
        }
        if(moveVector.x == 0 && moveVector.y == 0){anim.SetBool("isRunning", false);}

        rb.MovePosition(rb.position + moveVector.normalized * speed * Time.deltaTime);
        }
    }
