using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class AbstractMonsterView : MonoBehaviour, IPointerClickHandler, IMonstersView
{
    public event EventHandler<MonsterPositionChangedEvent> OnMonsterPositionChanged = (sender, e) => { };
    public event EventHandler<MonsterHitEvent> OnMonsterHitByRay = (sender, e) => { };
    public event EventHandler<MonsterSpeakingEvent> OnMonsterSpeaking = (sender, e) => { };
    public event EventHandler<MonsterNextDialogue> OnMonsterNextDialogue = (sender, e) => { };
    public GameObject DialogueBox;
    public Text DialogueTextMeshObj;

    protected IMonstersModel model;
    protected IMonstersController controller;
    protected bool showDialogue = false;
    protected TextMesh dialogueText;

    private void Update()
    {
        // if there is a mouse click on this frame
        if (Input.GetMouseButtonDown(0))
        {
           
        }
    }

    private void Awake()
    {
        dialogueText = DialogueTextMeshObj.GetComponent<TextMesh>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        ShowDialogue();
    }

    // emit an event that will be captured by the monstercontroller, who will update the monstermodel
    public void MonsterHitByRay()
    {
        controller.MonsterHitByRay();
    }

    public void ShowDialogue()
    {
        showDialogue = !showDialogue;
        DialogueBox.SetActive(showDialogue);
        var sentence = controller.FetchMonsterDialogue();
        Debug.Log(sentence);
    }

    public void DisplayNextDialogue(string sentence)
    {
        dialogueText.text = sentence;
    }

    public void UpdateHealth()
    {
        throw new NotImplementedException();
    }

    public void UpdatePosition()
    {
        throw new NotImplementedException();
    }

}
