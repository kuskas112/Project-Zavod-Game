using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;


public class InputManager : MonoBehaviour
{
    void Update()
    {
        if (ConversationManager.Instance != null){
            if (ConversationManager.Instance.IsConversationActive){
                if (Input.GetKeyDown(KeyCode.Space)){
                    ConversationManager.Instance.PressSelectedOption();
                }
            }
        }
    }
}

