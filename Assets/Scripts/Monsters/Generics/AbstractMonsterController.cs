using UnityEngine;

public class AbstractMonsterController : IMonstersController
{
    protected IMonstersModel model;
    protected DialogueManager dialogueManager;
    protected Inventory inventory;
    protected GameManager gameManager;

    public AbstractMonsterController(IMonstersModel IModel)
    {
        model = IModel;
    }

    public virtual void MonsterSpeaking()
    {
        inventory = Inventory.instance;
        dialogueManager = DialogueManager.instance;

        if (inventory != null && inventory.selectedItem)
        {
            if (inventory.selectedItem.name == model.chest.name)
            {
                dialogueManager.StartDialogue(model.dialogueForChest);
            }
            else
            {
                dialogueManager.StartDialogue(model.monsterDialogue);
            }
        }
        else
        {
            dialogueManager.StartDialogue(model.monsterDialogue);
        }
    }

    public void MonsterHitByRay()
    {
        Debug.Log("monster hit");
        //Debug.Log($"{model.MonsterName} has been Hit");
        //model.MonsterHealth = -10;
        //Debug.Log($"{model.MonsterName}'s current health is {model.MonsterHealth}");
    }

}
