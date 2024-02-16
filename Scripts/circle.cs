using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circle : MonoBehaviour
{
    private Camera camera;
    void Start()
    {
        camera = GameObject.Find("Main Camera").GetComponent<Camera>();
    }

    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player"){
            ZoomCamera.isActive = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player"){
            ZoomCamera.isActive = false;
        }
    }
}
