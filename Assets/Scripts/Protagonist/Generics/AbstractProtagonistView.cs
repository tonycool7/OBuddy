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

    private float Speed => Time.deltaTime * movementSpeed;
    public Vector2 TargetPosition
    {
        get { return _TargetPosition; }
        set
        {
            _TargetPosition = value;
        }
    }

    private void Awake()
    {
        protagonistAnimator = transform.GetComponent<Animator>();
    }
    private void Update()
    {
        MoveProtagonist();
    }

    public virtual void MoveProtagonist()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _TargetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Moving = true;
            CastRay();
            //var EventArg = new GameCharacterMovedEvent();
            //OnCharacterMoved(this, EventArg);
        }

        if (Moving && (Vector2)transform.position != _TargetPosition)
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

    public void CastRay()
    {
        Debug.Log("Casting ray");
        Vector3 screenMouseClick = Input.mousePosition;
        Vector2 worldClickPostion = Camera.main.ScreenToWorldPoint(screenMouseClick);

        RaycastHit2D hit = Physics2D.Raycast(worldClickPostion, Vector2.zero, 20f);

        if (hit)
        {
            IMonstersView monster = hit.collider.GetComponent<IMonstersView>();
            if (monster != null) monster.MonsterHitByRay();
        }

        //Method to draw the ray in scene for debug purpose
        Debug.DrawRay(transform.position, Vector2.right * 20f, Color.red);
    }

    public virtual void SetAnimation(float direction)
    {
        protagonistAnimator.SetBool("InMotion", Moving);
        transform.rotation = (direction > 0f) ? Quaternion.AngleAxis(-180, Vector3.up) : Quaternion.AngleAxis(0, Vector3.up);
    }
}
