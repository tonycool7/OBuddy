using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractMonsterController : IMonstersController
{
    private IMonstersModel Model;
    private IMonstersView View;

    public AbstractMonsterController(IMonstersModel IModel, IMonstersView IView)
    {
        Model = IModel;
        View = IView;
        View.OnMonsterHitByRay += MonsterHitByRay;
    }

    public void MonsterHitByRay(object Sender, MonsterHitEvent e)
    {
        Debug.Log($"{Model.MonsterName} has been Hit");
        Model.MonsterHealth = -10;
        Debug.Log($"{Model.MonsterName}'s current health is {Model.MonsterHealth}");
    }

}
