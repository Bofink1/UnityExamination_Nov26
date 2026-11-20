using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    public static DialogueManager instance;
    private DialogueUI dialogueUI;

    private void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);

        dialogueUI = FindObjectOfType<DialogueUI>();
    }

    public void StartDialogue(DialogueNode node)
    {
        dialogueUI.StartDialogue(node);
    }

    public void ChooseOption(DialogueOption option)
    {

      

        
        // continue or end dialogue
        if (option.nextNode != null)
        {
            dialogueUI.StartDialogue(option.nextNode);
            if (option.destroyOnClose != null)
            {
                option.destroyOnClose.SetActive(false);
            }
        }
        else
        {
            dialogueUI.EndDialogue();
        }
    }
}