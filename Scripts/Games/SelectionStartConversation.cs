using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class SelectionStartConversation : MonoBehaviour
{
    void Start()
    {   
        Timer.timeStopped = true;
        GameObject convObj = GameObject.Find("Level" + LevelManager.currentLevel.ToString());
        if(convObj != null){
            NPCConversation conv = convObj.GetComponent<NPCConversation>();
            ConversationManager.Instance.StartConversation(conv);
        }
        else{
            Timer.timeStopped = false;
        }
        
    }

    public void StartGame(){
        Timer.timeStopped = false;
    }

}
