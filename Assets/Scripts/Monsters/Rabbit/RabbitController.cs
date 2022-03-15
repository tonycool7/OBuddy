using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitController : AbstractMonsterController
{
    public IMonstersModel RabbitModel;
    public IMonstersView RabbitView;
    public RabbitController(IMonstersModel Model, IMonstersView View)
    {
        RabbitModel = Model;
        RabbitView = View;
        RabbitView.OnMonsterHitByRay += MonsterHitByRay;
    }

    public void MonsterHitByRay(object Sender, MonsterHitEvent e)
    {
        Debug.Log("Monster Hit");
        RabbitModel.MonsterHealth = -10;
        Debug.Log(RabbitModel.MonsterHealth);
    }
}
