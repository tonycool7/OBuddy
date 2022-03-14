using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProtagonistController : AbstractProtagonistController
{
    public IProtaginistModel Model { get; private set; }
    public IProtaginistView View { get; private set; }

    public ProtagonistController(IProtaginistModel SpecificModel, IProtaginistView SpecificView)
    {
        Model = SpecificModel;
        View = SpecificView;
        View.OnCharacterMoved += HandlePositionChanged;
        Debug.Log("Protagonist Controller");
    }

    // Called when the model's position changes
    private void HandlePositionChanged(object sender, GameCharacterMovedEvent e)
    {
        // Update the view with the new position
        SyncPosition();
    } 

    // Sync the view's position with the model's position
    private void SyncPosition()
    {
        Model.CurrentPosition = View.TargetPosition;
    }

}
