using UnityEngine;

public class LizardController : AbstractMonsterController
{
    LizardModel lizardModel;

    public LizardController(LizardModel Model) : base(Model)
    {
        lizardModel = Model;
    }

    public override void MonsterSpeaking()
    {
        base.MonsterSpeaking();
        gameManager = GameManager.instance;

        if (inventory != null && inventory.selectedItem && inventory.selectedItem.name == lizardModel.handCuff.name)
        {
            if (levelOne)
            {
            dialogueManager.StartDialogue(lizardModel.dialogueForHandCuff);
            }
            else
            { 
            gameManager.goToBadEnding = true;
            dialogueManager.StartDialogue(lizardModel.dialogueForHandCuff);
            }
        }
    }
}
