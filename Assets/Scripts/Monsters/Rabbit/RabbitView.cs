using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitView : AbstractMonsterView
{
    public RabbitModel AModel;
    void Awake()
    {
        controller = new RabbitController(AModel);
    }
}
