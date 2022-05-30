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

        if (inventory != null && inventory.selectedItem && inventory.selectedItem.name == rabbitModel.chest.name)
        {
            inventory.Remove(inventory.selectedItem);
        }
    }
}
