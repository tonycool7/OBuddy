using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProtagonistView : View
{
    public float MovementSpeed = 10f;
    public Animator ProtagonistAnimator;
    public SpriteRenderer ProtagonistRenderer;
    private float _Direction;
    private bool Moving = false;
    Vector2 LastClickedPosition;
    float Speed => Time.deltaTime * MovementSpeed;


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            LastClickedPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Moving = true;
        }

        if (Moving && (Vector2)transform.position != LastClickedPosition)
        {
            _Direction = transform.position.x > LastClickedPosition.x ? 1f : -1f;
            transform.position = Vector2.MoveTowards(transform.position, LastClickedPosition, Speed);
        }
        else
        {
            _Direction = 0;
        }
        SetAnimation(_Direction);
    }

    public void SetAnimation(float direction)
    {
        ProtagonistAnimator.SetFloat("Horizontal", direction);
        ProtagonistRenderer.flipX = (direction > 0f);
    } 
}
