using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class DialogueUI : MonoBehaviour
{
    [Header("Main")]
    public TextMeshProUGUI dialogueText;
    public Button[] optionButtons;
    public GameObject panel;
    public static GameObject ToBeDestroyed;
    public static GameObject ToBeLoaded;
    private DialogueNode currentNode;
   
  
   
 


    private void Start()
    {
        
        // Hide UI at start
        panel.SetActive(false);
   
    
    }

    public void StartDialogue(DialogueNode node)
    {
        panel.SetActive(true); // Show UI when dialogue starts
     


        currentNode = node;
        dialogueText.text = node.npcText;

        for (int i = 0; i < optionButtons.Length; i++)
        {
            if (i < node.options.Length)
            {
                optionButtons[i].gameObject.SetActive(true);
                optionButtons[i].GetComponentInChildren<TextMeshProUGUI>().text = node.options[i].text;

                int optionIndex = i;
                optionButtons[i].onClick.RemoveAllListeners();
                optionButtons[i].onClick.AddListener(() => OnOptionSelected(optionIndex));
            }
            else
            {
                optionButtons[i].gameObject.SetActive(false);
            }
        }
    }

    private void OnOptionSelected(int index)
    {
        DialogueOption option = currentNode.options[index];
        DialogueManager.instance.ChooseOption(option);
    }

    public void EndDialogue()
    {
        if (ToBeDestroyed != null)
        {
            Destroy(ToBeDestroyed);
        }
        ToBeLoaded.SetActive(true);
        panel.SetActive(false); // Hide UI when dialogue ends
    }
}