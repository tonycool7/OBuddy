using System;
using UnityEngine;

public abstract class AbstractProtagonistView : MonoBehaviour, IProtaginistView
{
    public float movementSpeed = 20f;
    public event EventHandler<GameCharacterMovedEvent> OnCharacterMoved = (sender, e) => { };

    private Vector2 _TargetPosition;
    private float _Direction;
    private bool Moving = false;
    private Animator protagonistAnimator;

    protected IProtaginistModel model;
    protected IProtaginistController controller;
    protected bool collisionDetected = false;

    private float Speed => Time.deltaTime * movementSpeed;

    protected void Start()
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
        Debug.Log(collision.tag);
    }

    protected void MoveProtagonist()
    {
        if (Moving && (Vector2)transform.position != _TargetPosition && !model.CollisionDetected)
        {
            _Direction = transform.position.x > _TargetPosition.x ? 1f : -1f;
            transform.position = Vector2.MoveTowards(transform.position, _TargetPosition, Speed);
        }
        else
        {
            _Direction = 0;
            Moving = false;
        }

        SetAnimation(_Direction);
    }

    protected void CastRay()
    {
        Debug.Log("Casting ray");
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
        transform.rotation = (direction > 0f) ? Quaternion.AngleAxis(-180, Vector3.up) : Quaternion.AngleAxis(0, Vector3.up);
    }
}
