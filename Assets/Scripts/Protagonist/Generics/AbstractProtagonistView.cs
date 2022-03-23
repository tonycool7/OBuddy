using System;
using UnityEngine;

public abstract class AbstractProtagonistView : MonoBehaviour, IProtaginistView
{
    public float movementSpeed = 20f;
    public event EventHandler<GameCharacterMovedEvent> OnCharacterMoved = (sender, e) => { };
    public Vector3 cameraOffset;
    [Range(1,10)]
    public float cameraSmoothFactor;

    private Vector2 _TargetPosition;
    private float _Direction;
    private bool Moving = false;
    private Animator protagonistAnimator;

    protected IProtaginistModel model;
    protected IProtaginistController controller;
    protected bool collisionDetected = false;

    private float Speed => Time.deltaTime * movementSpeed;

    void Awake()
    {
        _TargetPosition = transform.position;
    }
    void Start()
    {
        protagonistAnimator = transform.GetComponent<Animator>();
    }

    protected void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Moving = true;
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
            IMonstersView monster = collision.GetComponent<IMonstersView>();
            if (monster != null) monster.ShowDialogue();
        }
    }

    protected void MoveProtagonist()
    {
        if (Moving && (Vector2)transform.position != _TargetPosition && !model.CollisionDetected)
        {
            _Direction = transform.position.x > _TargetPosition.x ? 1f : -1f;
            transform.position = Vector2.MoveTowards(transform.position, _TargetPosition, Speed);
            UpdateCameraPosition();
        }
        else
        {
            _Direction = 0;
            Moving = false;
        }

        SetAnimation(_Direction);
    }

    private void UpdateCameraPosition()
    {
        Vector3 smoothPostion = Vector3.Lerp(Camera.main.transform.position, (Vector3)_TargetPosition + cameraOffset, cameraSmoothFactor*Time.deltaTime);
        Camera.main.transform.position = smoothPostion;
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
                    _TargetPosition = hit.point;
                    break;
                case "Monster":
                    IMonstersView monster = hit.collider.GetComponent<IMonstersView>();
                    if (monster != null) monster.MonsterHitByRay();
                    break;
                default:
                    break;
            }
           
        }
    }

    protected virtual void SetAnimation(float direction)
    {
        protagonistAnimator.SetBool("InMotion", Moving);
        transform.GetComponent<SpriteRenderer>().flipX = (direction > 0f);
    }
}
