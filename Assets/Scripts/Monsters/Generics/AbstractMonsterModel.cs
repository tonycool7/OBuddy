using UnityEngine;

public abstract class AbstractMonsterModel : MonoBehaviour, IMonstersModel
{
    protected Vector2 _MonsterPosition;
    protected float _MonsterHealth = 100;
    protected bool _Aggressor = false;
    protected string _MonsterName;
    public Dialogue _dialogueForHandCuff;
    public Item _handCuff;
    public Dialogue _dialogueForChest;
    public Item _chest;

    public Dialogue _monsterDialogue;

    virtual public Vector2 MonsterPosition { get { return _MonsterPosition; } set { _MonsterPosition = value; } }
    virtual public float MonsterHealth {
        get { return _MonsterHealth; } 
        set { _MonsterHealth += ((_MonsterHealth + value) >= value) ? value : 0; } 
    }
    virtual public Dialogue monsterDialogue { get { return _monsterDialogue; } set { _monsterDialogue = value; } }
    virtual public bool Aggressor { get { return _Aggressor; } set { _Aggressor = value; } }
    virtual public string MonsterName { get { return _MonsterName; } set { _MonsterName = value; } }

    virtual public Dialogue dialogueForHandCuff { get { return _dialogueForHandCuff; } set { _dialogueForHandCuff = value; } }

    virtual public Item handCuff { get { return _handCuff; } set { _handCuff = value; } }
    virtual public Dialogue dialogueForChest { get { return _dialogueForChest; } set { _dialogueForChest = value; } }

    virtual public Item chest { get { return _chest; } set { _chest = value; } }
}
