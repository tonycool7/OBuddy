using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProtagonistController : Controller
{
    public ProtagonistModel Model { get; private set; }
    public ProtagonistView View { get; private set; }
    public ProtagonistController(ProtagonistModel SpecificModel, ProtagonistView SpecificView)
    {
        Model = SpecificModel;
        View = SpecificView;
        Debug.Log("Protagonist Controller");
    }

}
