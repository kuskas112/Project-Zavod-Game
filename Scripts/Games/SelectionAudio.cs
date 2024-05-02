using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionAudio : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip everyThrow;
    public AudioClip[] goodClips;
    public AudioClip[] badClips;
    private Animator anim;
    private void Start() {
        anim = GetComponent<Animator>();
    }
    public void PlayEveryThrow(){
        audioSource.PlayOneShot(everyThrow);
    }
    public void PlaySituationallyThrow(){
        bool success = anim.GetBool("SuccessThrow");
        if (success){
            System.Random rnd = new System.Random();
            int rndIndex = rnd.Next(0, goodClips.Length);
            audioSource.PlayOneShot(goodClips[rndIndex]);
        }
        else{
            System.Random rnd = new System.Random();
            int rndIndex = rnd.Next(0, badClips.Length);
            audioSource.PlayOneShot(badClips[rndIndex]);
        }
    }

}
