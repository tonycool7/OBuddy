public class RabbitController : AbstractMonsterController
{
    RabbitModel rabbitModel;

    public RabbitController(RabbitModel Model) : base(Model)
    {
        rabbitModel = Model;
    }

    public override void MonsterSpeaking()
    {
        base.MonsterSpeaking();
        gameManager = GameManager.instance;
        inventory = Inventory.instance;
        dialogueManager = DialogueManager.instance;

        if (inventory != null && inventory.selectedItem && inventory.selectedItem.name == rabbitModel.chest.name)
        {
            inventory.Remove(inventory.selectedItem);
            gameManager.SetHasGivenRabbitChest(true);
        }
        else if (inventory != null && inventory.selectedItem && inventory.selectedItem.name == rabbitModel.handCuff.name)
        {
            if (gameManager.levelOne)
            {
            dialogueManager.StartDialogue(rabbitModel.dialogueForHandCuff);
            }
            else
            { 
            gameManager.goToHappyEnding = true;
            dialogueManager.StartDialogue(rabbitModel.dialogueForHandCuff);
            }
        }
    }
}
