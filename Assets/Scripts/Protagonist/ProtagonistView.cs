using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProtagonistView : View
{
    public float MovementSpeed = 3f;
    public Animator ProtagonistAnimator;
    private float _Direction;
    private bool Moving = false;
    Vector2 LastClickedPosition;
    float Speed => Time.deltaTime * MovementSpeed;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            LastClickedPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Moving = !!Input.GetMouseButtonDown(0);
        }

        if (Moving && (Vector2)transform.position != LastClickedPosition)
        {
            _Direction = transform.position.x > LastClickedPosition.x ? 1f : -1f;
            transform.position = Vector2.MoveTowards(transform.position, LastClickedPosition, Speed);
            SetAnimation(_Direction);
        }
        else
        {
            _Direction = 0;
            SetAnimation(_Direction);
        }
    }

    public void SetAnimation(float direction)
    {
        ProtagonistAnimator.SetFloat("Horizontal", direction);
        transform.rotation = (direction > 0f) ? Quaternion.AngleAxis(-180, Vector3.up) : Quaternion.AngleAxis(0, Vector3.up);
    } 
}
