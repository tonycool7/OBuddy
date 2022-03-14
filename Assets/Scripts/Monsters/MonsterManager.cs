using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterManager : MonoBehaviour
{
    public LizardModel LMonsterModel;
    public LizardView LMonsterView;
    public LizardController LMonsterController;

    void Awake()
    {
        LMonsterController = new LizardController(LMonsterModel, LMonsterView);
    }
}
