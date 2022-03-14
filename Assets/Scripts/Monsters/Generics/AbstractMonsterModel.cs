using System;
using UnityEngine;

public abstract class AbstractMonsterModel : MonoBehaviour, IMonstersModel
{
    protected Vector2 _MonsterPosition;
    protected float _MonsterHealth = 100;
    protected Enum _MonsterDialogues;
    protected bool _Aggressor = false;

    virtual public Vector2 MonsterPosition { get { return _MonsterPosition; } set { _MonsterPosition = value; } }
    virtual public float MonsterHealth {
        get { return _MonsterHealth; } 
        set { _MonsterHealth += (_MonsterHealth >= value) ? value : 0; } 
    }
    virtual public Enum MonsterDialogues { get { return _MonsterDialogues; } set { _MonsterDialogues = value; } }
    virtual public bool Aggressor { get { return _Aggressor; } set { _Aggressor = value; } }
}
