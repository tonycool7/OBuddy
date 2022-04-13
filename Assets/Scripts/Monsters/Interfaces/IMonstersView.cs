using System.Collections;
using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class MonsterPositionChangedEvent : EventArgs { }
public class MonsterHitEvent : EventArgs { }
public class MonsterSpeakingEvent : EventArgs { }
public class MonsterNextDialogue : EventArgs { }

public interface IMonstersView
{
    public event EventHandler<MonsterPositionChangedEvent> OnMonsterPositionChanged;
    public event EventHandler<MonsterHitEvent> OnMonsterHitByRay;
    public event EventHandler<MonsterSpeakingEvent> OnMonsterSpeaking;
    public event EventHandler<MonsterNextDialogue> OnMonsterNextDialogue;

    public void UpdatePosition();
    public void UpdateHealth();
 //   public void ShowDialogue();
    public void MonsterHitByRay();
 //   public void DisplayNextDialogue(string sentence);

}
