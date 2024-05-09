using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class ZavodConv : MonoBehaviour
{
    public NPCConversation conv;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player"){
            ConversationManager.Instance.StartConversation(conv);
        }
    }

}
