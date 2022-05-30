
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
       
        if (inventory != null && inventory.selectedItem)
        {
            if (inventory.selectedItem.name == catModel.key.name)
            {
                catModel.cage.SetActive(false);
                inventory.Remove(inventory.selectedItem);
                dialogueManager.StartDialogue(catModel.dialogueForKey);
            } else if (inventory.selectedItem.name == catModel.chest.name)
            {
                dialogueManager.StartDialogue(catModel.dialogueForChest);
            }
            else if (inventory.selectedItem.name == catModel.handCuff.name)
            {
                dialogueManager.StartDialogue(catModel.dialogueForHandCuff);
            }
        } else
        {
            dialogueManager.StartDialogue(catModel.monsterDialogue);
        }
    }
}
