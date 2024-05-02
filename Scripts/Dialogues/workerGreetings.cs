using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
using UnityEngine.SceneManagement;


public class workerGreetings : MonoBehaviour
{
    public NPCConversation conv;
    void Start()
    {
        ConversationManager.Instance.StartConversation(conv);
    }

    public void StartSelectionGame(){
        SceneManager.LoadScene(2);
    }


}
