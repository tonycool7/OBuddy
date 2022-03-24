using System;
using UnityEngine;

public class GameCharacterMovedEvent : EventArgs { }

public interface IProtaginistView
{
    public event EventHandler<GameCharacterMovedEvent> OnCharacterMoved;
}
