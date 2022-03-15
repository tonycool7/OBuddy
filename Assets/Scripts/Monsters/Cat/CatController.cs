using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : AbstractMonsterController
{
    private IMonstersModel CatModel;
    private IMonstersView CatView;

    public CatController(IMonstersModel Model, IMonstersView View)
    {
        CatModel = Model;
        CatView = View;
        CatView.OnMonsterHitByRay += MonsterHitByRay;
    }

    public void MonsterHitByRay(object Sender, MonsterHitEvent e)
    {
        Debug.Log("Monster Hit");
        CatModel.MonsterHealth = -10;
        Debug.Log(CatModel.MonsterHealth);
    }
}
