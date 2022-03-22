using UnityEngine;
using System;

public abstract class AbstractProtagonistModel : MonoBehaviour, IProtaginistModel
{
	private Vector2 _CurrentPosition;

	public event EventHandler<PositionChangedEventArgs> OnPositionChanged = (sender, e) => { };

	public Vector2 CurrentPosition {
		get { return _CurrentPosition;  }
		set
		{
			// Only if the position changes
			if (_CurrentPosition != value)
			{
				// Set new position
				_CurrentPosition = value;

				// Dispatch the 'position changed' event
				var eventArgs = new PositionChangedEventArgs();
				OnPositionChanged(this, eventArgs);
			}
		}
	}
}