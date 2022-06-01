using System;
using UnityEngine;

// Dispatched when the enemy's position changes
public class PositionChangedEventArgs : EventArgs
{
}

public interface IProtaginistModel
{
    event EventHandler<PositionChangedEventArgs> OnPositionChanged;
    Vector2 currentPosition { get;  set; }
    bool collisionDetected { get; set; }
}
