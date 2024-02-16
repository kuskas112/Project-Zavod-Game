using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    private bool isPlayerInside = false;
    private bool wasEpressed = false;
    private GameObject eKey;
    private Animator anim;
    private AudioSource audio;
    private void Start() {
        eKey = GameObject.FindGameObjectWithTag("eKey");
        anim = GetComponent<Animator>();
        eKey.SetActive(false);
        audio = GetComponent<AudioSource>();
        audio.enabled = false;
    }

    private void Update() {//player pressed E
        if(Input.GetKey(KeyCode.E) && isPlayerInside && !wasEpressed){
            eKey.SetActive(false);
            anim.SetBool("isActive", !anim.GetBool("isActive"));
            audio.enabled = anim.GetBool("isActive");
        }
        if(Input.GetKey(KeyCode.E)){
            wasEpressed = true;
        }
        else{
            wasEpressed = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player"){
            eKey.SetActive(true);
            isPlayerInside = true;
        }
        Debug.Log("keke");
    }
    

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player"){
            eKey.SetActive(false);
            isPlayerInside = false;
        }
    }
}
