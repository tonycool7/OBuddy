using System;
using System.Collections;
using UnityEngine;

public abstract class AbstractMonsterModel : MonoBehaviour, IMonstersModel
{
    protected Vector2 _MonsterPosition;
    protected float _MonsterHealth = 100;
    protected Queue _MonsterDialogues;
    protected bool _Aggressor = false;
    protected string _MonsterName;
    virtual public Vector2 MonsterPosition { get { return _MonsterPosition; } set { _MonsterPosition = value; } }
    virtual public float MonsterHealth {
        get { return _MonsterHealth; } 
        set { _MonsterHealth += ((_MonsterHealth + value) >= value) ? value : 0; } 
    }
    virtual public Queue MonsterDialogues { get { return _MonsterDialogues; } set { _MonsterDialogues = value; } }
    virtual public bool Aggressor { get { return _Aggressor; } set { _Aggressor = value; } }
    virtual public string MonsterName { get { return _MonsterName; } set { _MonsterName = value; } }
}
