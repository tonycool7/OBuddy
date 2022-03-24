using System;
using UnityEngine;

// Dispatched when the enemy's position changes
public class PositionChangedEventArgs : EventArgs
{
}

public interface IProtaginistModel
{
    event EventHandler<PositionChangedEventArgs> OnPositionChanged;
    Vector2 CurrentPosition { get;  set; }
    bool CollisionDetected { get; set; }
}
