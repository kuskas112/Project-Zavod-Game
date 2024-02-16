using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallsTriggers : MonoBehaviour
{
    private SpriteRenderer sprite;
    private void Awake()
    {
        GameObject walls = GameObject.FindGameObjectWithTag("Player");
        sprite = walls.GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        sprite.sortingOrder = 100;
        Debug.Log("zasel");
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        sprite.sortingOrder = 5;
        Debug.Log("visel");
    }
    
}