using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ProtagonistView : AbstractProtagonistView
{
    private ProtagonistModel specificModel;

    public ProtagonistView()
    {
        controller = new ProtagonistController(specificModel);
        specificModel = new ProtagonistModel();
        model = specificModel;
    }

}
