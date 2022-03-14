using System;
using UnityEngine;
using UnityEngine.UI;

public abstract class AbstractMonsterView : MonoBehaviour, IMonstersView
{
    public event EventHandler<MonsterPositionChangedEvent> OnMonsterPositionChanged = (sender, e) => { };
    public event EventHandler<MonsterHitEvent> OnMonsterHitByRay = (sender, e) => { };
    public event EventHandler<MonsterSpeakingEvent> OnMonsterSpeaking = (sender, e) => { };
    public Image DialogueBox;

    private void Update()
    {
        // if there is a mouse click on this frame
        if (Input.GetMouseButtonDown(0))
        {
           
        }
    }

    // emit an event that will be captured by the monstercontroller, who will update the monstermodel
    public void MonsterHitByRay()
    {
        var HitEvent = new MonsterHitEvent();
        DialogueBox.enabled = true;
        OnMonsterHitByRay(this, HitEvent);
    }

    public void ShowDialogue()
    {
        throw new NotImplementedException();
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
