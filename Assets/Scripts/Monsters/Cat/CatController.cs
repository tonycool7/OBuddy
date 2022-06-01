using UnityEngine;

public class CatController : AbstractMonsterController
{
    CatModel catModel;

    public CatController(CatModel Model) : base(Model)
    {
        catModel = Model;
    }

    public override void MonsterSpeaking()
    {
        dialogueManager = DialogueManager.instance;
        inventory = Inventory.instance;
        gameManager = GameManager.instance;

        if (inventory != null && inventory.selectedItem)
        {
            if (inventory.selectedItem.name == catModel.key.name)
            {
                catModel.cage.SetActive(false);
                catModel.chestItem.SetActive(true);
                inventory.Remove(inventory.selectedItem);
                dialogueManager.StartDialogue(catModel.dialogueForKey);
                gameManager.UpdateFeedBack($"{catModel.name} has been set free");
                gameManager.SetCatFreeState(true);
            } else if (inventory.selectedItem.name == catModel.chest.name)
            {
                dialogueManager.StartDialogue(catModel.dialogueForChest);
            }
            else if (inventory.selectedItem.name == catModel.handCuff.name)
            {
                gameManager.goToBadEnding = gameManager.levelOne;
                dialogueManager.StartDialogue(catModel.dialogueForHandCuff);
            } 
        }
        else if (!catModel.cage.activeInHierarchy)
        {
            dialogueManager.StartDialogue(catModel.dialogueForFreeCat);
        }
        else
        {
            dialogueManager.StartDialogue(catModel.monsterDialogue);
        }
    }
}
