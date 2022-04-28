using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class AbstractMonsterView : MonoBehaviour, IMonstersView
{
    public event EventHandler<MonsterPositionChangedEvent> OnMonsterPositionChanged = (sender, e) => { };
    public event EventHandler<MonsterHitEvent> OnMonsterHitByRay = (sender, e) => { };
    public event EventHandler<MonsterSpeakingEvent> OnMonsterSpeaking = (sender, e) => { };
    public event EventHandler<MonsterNextDialogue> OnMonsterNextDialogue = (sender, e) => { };

    protected IMonstersModel model;
    protected IMonstersController controller;
    protected TextMeshProUGUI dialogueText;

    private void Update()
    {
    }

    private void Start()
    {
    }

    // emit an event that will be captured by the monstercontroller, who will update the monstermodel
    public void MonsterHitByRay()
    {
        controller.MonsterHitByRay();
    }

    public void UpdateHealth()
    {
        throw new NotImplementedException();
    }

    public void UpdatePosition()
    {
        throw new NotImplementedException();
    }

    public void InitiateDialogue()
    {
        controller.MonsterSpeaking();
    }

}
