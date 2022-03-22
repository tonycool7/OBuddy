using UnityEngine;
using UnityEngine.EventSystems;

public class LizardView : AbstractMonsterView
{
    public LizardModel AModel;

    private void Awake()
    {
        controller = new LizardController(AModel);
    }
}
