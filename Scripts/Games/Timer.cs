using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float startTime = 30;
    public TMP_Text timeCount;
    public static bool timeStopped = false;
    public static bool gameOver = false;
    void Start()
    {
        timeCount.text = startTime.ToString();
        timeStopped = false;
        gameOver = false;
    }

    void Update()
    {
        if(gameOver){return;}
        if (!timeStopped){
            startTime-= Time.deltaTime;
            timeCount.text = Mathf.Round(startTime).ToString();
        }
        if (startTime <= 0){
            timeStopped = true;
            gameOver = true;
            PlayerPrefs.SetInt("CurrentLevel", LevelManager.currentLevel+1);
        }
    }
}
