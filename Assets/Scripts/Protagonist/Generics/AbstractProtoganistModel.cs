using UnityEngine;
using System;

public abstract class AbstractProtagonistModel : MonoBehaviour, IProtaginistModel
{
	private Vector2 _currentPosition;
	private bool _collisionDetected = false;

	public event EventHandler<PositionChangedEventArgs> OnPositionChanged = (sender, e) => { };

	public Vector2 currentPosition {
		get { return _currentPosition;  }
		set
		{
			// Only if the position changes
			if (_currentPosition != value)
			{
				// Set new position
				_currentPosition = value;

				// Dispatch the 'position changed' event
				var eventArgs = new PositionChangedEventArgs();
				OnPositionChanged(this, eventArgs);
			}
		}
	}

    public bool collisionDetected { get => _collisionDetected; set { _collisionDetected = value;  } }
}
