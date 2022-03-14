using System;
using UnityEngine;

public class GameCharacterMovedEvent : EventArgs { }

public interface IProtaginistView
{
    public Vector2 TargetPosition { get; set; }

    public event EventHandler<GameCharacterMovedEvent> OnCharacterMoved;
}
