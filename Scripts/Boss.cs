using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    private Animator anim;
    private SpriteRenderer sprite;

    private AudioSource audioPhonk;
    private AudioSource audioTpOut;
    private AudioSource audioTpIn;
    public GameObject phonk;
    public GameObject tpOut;
    public GameObject tpIn;
    private int cnt = 0;


    private void Start() {
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        audioPhonk = phonk.GetComponent<AudioSource>();
        audioTpOut = tpOut.GetComponent<AudioSource>();
        audioTpIn = tpIn.GetComponent<AudioSource>();
        audioPhonk.enabled = false;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        cnt++;
        if (other.gameObject.tag == "Player"){
            if (anim.GetBool("visible"))
            {
                anim.SetBool("visible", false);
            }
            else{
                anim.SetBool("visible", true);
                if(cnt == 4){
                    anim.SetBool("isAngry", true);
                    audioPhonk.enabled = true;
                }
                
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

    private void OnTpSound(string msg){
        if(msg == "tpOut"){
            audioTpOut.Play();
            return;
        }
        if(msg == "tpIn"){
            audioTpIn.Play();
            return;
        }
        
    }
}
