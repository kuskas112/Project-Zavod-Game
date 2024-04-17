using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    // Start is called before the first frame update
    private bool isPlayerInside = false;
    private bool wasEpressed = false;
    public GameObject eKey;
    private void Start() {
        eKey.SetActive(false);
    }

    private void Update() {//player pressed E
        if(Input.GetKey(KeyCode.E) && isPlayerInside && !wasEpressed){
            eKey.SetActive(false);
            SceneManager.LoadScene(2);
            return;
        }
        if(Input.GetKey(KeyCode.E)){
            wasEpressed = true;
        }
        else{
            wasEpressed = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player"){
            eKey.SetActive(true);
            isPlayerInside = true;
        }
    }
    

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player"){
            eKey.SetActive(false);
            isPlayerInside = false;
        }
    }
}
