using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;
    private Queue<string> sentences;

    public Animator animator;



    private void Start()
    {
        sentences = new Queue<string>();

    }

    public void StartDialogue(Dialogue dialogue)
    {

        animator.SetBool("IsOpen", true);
        nameText.text = dialogue.name;
        sentences.Clear();

        foreach (string  sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;


    }
    /*
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
    */

    void EndDialogue()
    {
        animator.SetBool("IsOpen", false);
    }
    

}
