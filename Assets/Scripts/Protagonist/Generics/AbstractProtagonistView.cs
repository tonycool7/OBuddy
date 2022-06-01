using System;
using UnityEngine;

public abstract class AbstractProtagonistView : MonoBehaviour, IProtaginistView
{
    public float movementSpeed = 20f;
    public event EventHandler<GameCharacterMovedEvent> OnCharacterMoved = (sender, e) => { };

    private float _direction;
    private bool moving = false;
    private Animator protagonistAnimator;
    private DialogueManager dialogueManager;
    private string monsterTag = "Monster";
    private string arrowTag = "Arrow";
    IProtaginistModel model;
    IProtaginistController controller;
    GameManager gameManager;

    public Transform modelObj;
    public Transform controllerObj;
    protected bool collisionDetected = false;

    private float Speed => Time.deltaTime * movementSpeed;

    void Awake()
    {
    }
    void Start()
    {
        model = modelObj.GetComponent<IProtaginistModel>();
        controller = controllerObj.GetComponent<IProtaginistController>();
        model.currentPosition = transform.position;
        gameManager = GameManager.instance;
        dialogueManager = DialogueManager.instance;
        protagonistAnimator = transform.GetComponent<Animator>();
    }

    protected void Update()
    {
        if (Input.GetMouseButtonDown(0) && !dialogueManager.isDialoueOpen)
        {
            moving = true;
            model.collisionDetected = false;
            controller.PointAndMove();
        }
        MoveProtagonist();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        model.collisionDetected = true;
        if (collision.tag == monsterTag)
        {
            IMonstersView monster = collision.GetComponent<IMonstersView>();
            if (monster != null) monster.InitiateDialogue();
        }
    }

    protected void MoveProtagonist()
    {
        if (moving && (Vector2)transform.position != model.currentPosition && !model.collisionDetected)
        {
            _direction = transform.position.x > model.currentPosition.x ? 1f : -1f;
            transform.position = Vector2.MoveTowards(transform.position, model.currentPosition, Speed);
            SetAnimation(_direction);
        }
        else
        {
            _direction = 0;
            moving = false;
        }

    }

    protected virtual void SetAnimation(float direction)
    {
        protagonistAnimator.SetBool("InMotion", moving);
        transform.GetComponent<SpriteRenderer>().flipX = (direction > 0f);
    }
}
