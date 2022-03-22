using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager
{
    private string[] dialogues;
    private Queue<string> dialogueQueue;

    public DialogueManager(string[] sentences)
    {
        dialogues = sentences;
        dialogueQueue = new Queue<string>();
    }

    public void PrepareDialogues()
    {
        foreach(string dialogue in dialogues)
        {
            dialogueQueue.Enqueue(dialogue);
        }
    }

    public string GetNextDialogue()
    {
        if(dialogueQueue.Count == 0)
        {
            EndDialogue();
            return "";
        }
        return dialogueQueue.Dequeue();
    }

    public void EndDialogue()
    {

    }


}
