using System;
using UnityEngine;

public abstract class AbstractProtagonistView : MonoBehaviour, IProtaginistView
{
    public float movementSpeed = 20f;
    public event EventHandler<GameCharacterMovedEvent> OnCharacterMoved = (sender, e) => { };

    private Vector2 _targetPosition;
    private float _direction;
    private bool moving = false;
    private Animator protagonistAnimator;
    private DialogueManager dialogueManager;

    protected IProtaginistModel model;
    protected IProtaginistController controller;
    protected bool collisionDetected = false;

    private float Speed => Time.deltaTime * movementSpeed;

    void Awake()
    {
        _targetPosition = transform.position;
    }
    void Start()
    {
        dialogueManager = DialogueManager.instance;
        protagonistAnimator = transform.GetComponent<Animator>();
    }

    protected void Update()
    {
        if (Input.GetMouseButtonDown(0) && !dialogueManager.isDialoueOpen)
        {
            moving = true;
            model.CollisionDetected = false;
            CastRay();
        }
        MoveProtagonist();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        model.CollisionDetected = true;
        if (collision.tag == "Monster")
        {
            print("we hit a monster!");
            IMonstersView monster = collision.GetComponent<IMonstersView>();
            if (monster != null) monster.InitiateDialogue();
        }
    }

    protected void MoveProtagonist()
    {
        if (moving && (Vector2)transform.position != _targetPosition && !model.CollisionDetected)
        {
            _direction = transform.position.x > _targetPosition.x ? 1f : -1f;
            transform.position = Vector2.MoveTowards(transform.position, _targetPosition, Speed);
        }
        else
        {
            _direction = 0;
            moving = false;
        }

        SetAnimation(_direction);
    }

    protected void CastRay()
    {
        Vector3 screenMouseClick = Input.mousePosition;
        Vector2 worldClickPostion = Camera.main.ScreenToWorldPoint(screenMouseClick);

        RaycastHit2D hit = Physics2D.Raycast(worldClickPostion, Vector2.zero, 20f);
     
        if (hit)
        {
            switch (hit.collider.tag)
            {
                case "Floor":
                    _targetPosition = hit.point;
                    break;
                case "Monster":
                    IMonstersView monster = hit.collider.GetComponent<IMonstersView>();
                    if (monster != null) monster.MonsterHitByRay();
                    _targetPosition = hit.point;
                    break;
                default:
                    break;
            }
        }
    }

    protected virtual void SetAnimation(float direction)
    {
        protagonistAnimator.SetBool("InMotion", moving);
        transform.GetComponent<SpriteRenderer>().flipX = (direction > 0f);
    }
}
