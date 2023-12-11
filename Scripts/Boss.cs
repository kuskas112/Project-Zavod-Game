using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    private Animator anim;
    private SpriteRenderer sprite;


    private void Start() {
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player"){
            Debug.Log("KEKEK");
            if (anim.GetBool("visible"))
            {
                anim.SetBool("visible", false);
            }
            else{
                anim.SetBool("visible", true);
            }
        }
    }
    private void OnTp(string msg){
        if(msg == "tpEnded"){
            sprite.enabled = false;
            return;
        }
        if(msg == "tpStarted"){
            sprite.enabled = true;
            return;
        }
        
    }
}
