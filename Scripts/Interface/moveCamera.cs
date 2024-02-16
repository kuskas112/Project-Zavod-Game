using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class moveCamera : MonoBehaviour
{
    public float range;
    public Transform playerObj;
    private Vector3 playerPos;
    private Vector3 camPos;
    // Start is called before the first frame update

    
    // Update is called once per frame
    void Update()
    {
        camPos = this.transform.position;
        playerPos = playerObj.position;

        if(playerPos.x - camPos.x >= range){
            camPos.x = playerPos.x - range;
        }
        else if(playerPos.x - camPos.x <= -range){
            camPos.x = playerPos.x + range;
        }
        if(playerPos.y - camPos.y >= range){
            camPos.y = playerPos.y - range;
        }
        else if(playerPos.y - camPos.y <= -range){
            camPos.y = playerPos.y + range;
        }
        this.transform.position = camPos;
    }
}
