using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject pauseMenu;
    public static bool isPaused = false;
    public GameObject dialogueCanvas;
    private void Start() {
        pauseMenu.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)
            {
                pauseMenu.SetActive(false);
                isPaused = false;
                Time.timeScale = 1;
                dialogueCanvas.SetActive(true);
            }
            else
            {
                pauseMenu.SetActive(true);
                isPaused = true;
                Time.timeScale = 0;
                dialogueCanvas.SetActive(false);
            }
        }
        
    }



    public void Play(){
        pauseMenu.SetActive(false);
        isPaused = false;
        Time.timeScale = 1;
        dialogueCanvas.SetActive(true);
    }

    public void Save(){
        Debug.Log("saved");
    }

    public void Exit(){
        SceneManager.LoadScene(0);
    }
}
