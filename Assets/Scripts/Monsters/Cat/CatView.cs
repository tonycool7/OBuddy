using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatView : AbstractMonsterView
{
    public CatModel AModel;
    void Awake()
    {
        controller = new CatController(AModel);
    }
}
