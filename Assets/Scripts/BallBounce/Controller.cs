using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : AccessPoint
{
    // Handles the ball hit event
    public void OnBallGroundHit()
    {
        App.Model.IncreaseBounce();
        Debug.Log($"Bounce {App.Model.BounceCount}");
        if (App.Model.BounceCount >= App.Model.WinCondition)
        {
            App.View.Ball.enabled = false;
            App.View.Ball.GetComponent<Rigidbody>().isKinematic = true; // stops the ball
            OnGameComplete();
        }
    }

    // Handles the win condition
    public void OnGameComplete() { Debug.Log("Victory!!"); }
}
