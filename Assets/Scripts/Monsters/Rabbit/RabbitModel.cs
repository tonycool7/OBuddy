using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitModel : AbstractMonsterModel
{
    public GameObject arrowToNextLevel;

    private void Awake()
    {
        MonsterName = "Rabbit";
    }
}
