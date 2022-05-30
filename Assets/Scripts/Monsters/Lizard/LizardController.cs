using UnityEngine;

public class LizardController : AbstractMonsterController
{
    LizardModel lizardModel;

    public LizardController(LizardModel Model) : base(Model)
    {
        lizardModel = Model;
    }
}
