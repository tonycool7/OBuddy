using UnityEngine;

public class LizardController : AbstractMonsterController
{
    public IMonstersModel LizardModel { get; set; }
    public IMonstersView LizardView { get; set; }
    public LizardController(IMonstersModel Model, IMonstersView View)
    {
        LizardModel = Model;
        LizardView = View;
        LizardView.OnMonsterHitByRay += MonsterHitByRay;
    }

    public void MonsterHitByRay(object Sender, MonsterHitEvent e)
    {
        Debug.Log("Monster Hit");
        LizardModel.MonsterHealth = -10;
        Debug.Log(LizardModel.MonsterHealth);
    }
}
