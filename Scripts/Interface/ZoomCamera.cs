using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomCamera : MonoBehaviour
{
    private Camera camera;
    public static bool isActive = false;
    public float speed = 0.03f;
    void Start()
    {
        camera = GameObject.Find("Main Camera").GetComponent<Camera>();
    }

    void LateUpdate()
    {
        if(isActive)
        {
            camera.orthographicSize = Mathf.Lerp(camera.orthographicSize,5,speed);
        }
        else{
            camera.orthographicSize = Mathf.Lerp(camera.orthographicSize,9,speed);
        }
        
    }
}
