using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static int currentLevel;
    void Start()
    {
        if (PlayerPrefs.HasKey("CurrentLevel")){
            currentLevel = PlayerPrefs.GetInt("CurrentLevel");
        }
        else{
            currentLevel = 0;
        }
        Debug.Log("Current level: " + currentLevel);
    }

    
}
