using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainProtagonistController : ProtagonistController
{
    public MainProtagonistController(MainProtagonistModel SpecificModel, MainProtagonistView SpecificView) : base(SpecificModel, SpecificView)
    {
        Debug.Log("Main Protagonist Controller");
    }
}
