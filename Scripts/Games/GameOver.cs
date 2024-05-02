using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public GameObject dialogueCanvas;
    // Start is called before the first frame update
    void Start()
    {
        gameOverCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer.gameOver){
            gameOverCanvas.SetActive(true);
            dialogueCanvas.SetActive(false);
        }
    }

    public void HomeScene(){
        SceneManager.LoadScene(1);
    }

}
