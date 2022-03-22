using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractProtagonistController : IProtaginistController
{
    protected IProtaginistModel IModel;
    public AbstractProtagonistController(IProtaginistModel SpecificModel)
    {
        IModel = SpecificModel;
    }
}
