using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ProtagonistView : AbstractProtagonistView
{
    private ProtagonistModel specificModel;

    void Awake()
    {
        controller = new ProtagonistController(specificModel);
        specificModel = new ProtagonistModel();
        model = specificModel;
    }
}
