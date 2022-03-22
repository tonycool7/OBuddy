using UnityEngine;

public class MonsterManager : MonoBehaviour
{
    // Lizard Monster specific classes
    public LizardModel LizardMonsterModel;
    public LizardController LizardMonsterController;

    // Rabbit Monster specific classes
    public RabbitModel RabbitMonsterModel;
    public RabbitController RabbitMonsterController;

    // Cat Monster specific classes
    // Rabbit Monster specific classes
    public CatModel CatMonsterModel;
    public CatController CatMonsterController;

    // Initializing all monster controllers
    void Awake()
    {
        LizardMonsterController = new LizardController(LizardMonsterModel);
        RabbitMonsterController = new RabbitController(RabbitMonsterModel);
        CatMonsterController = new CatController(CatMonsterModel);
    }
}
