using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagScript : MonoBehaviour
{
    private Animator anim;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player"){
            Debug.Log("KEKEK");
            anim = other.gameObject.GetComponent<Animator>();
            anim.SetBool("withBag", true);
        }
    }

}
