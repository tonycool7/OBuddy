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

        if (inventory != null && inventory.selectedItem && inventory.selectedItem.name == rabbitModel.chest.name)
        {
            inventory.Remove(inventory.selectedItem);
            gameManager.SetHasGivenRabbitChest(true);
        }
        else if (inventory.selectedItem.name == rabbitModel.handCuff.name)
        {
            gameManager.goToHappyEnding = true;
            dialogueManager.StartDialogue(rabbitModel.dialogueForHandCuff);
        }
    }
}
