using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;


[System.Serializable]
public class DialogueOption
{
    [TextArea(2, 5)]
    public string text; // What the NPC says 
    public DialogueNode nextNode; // Next dialogue node 

    [Header("Optional Quest Actions")]
    public int objectiveIndex; //  which objective to complet
    public GameObject destroyOnClose;
}

[CreateAssetMenu(fileName = "New Dialogue Node", menuName = "Dialogue System/Dialogue Node")]
public class DialogueNode : ScriptableObject
{
    public string npcText;
    public DialogueOption[] options;
}