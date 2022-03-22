using UnityEngine;

public class MonsterManager : MonoBehaviour
{
    // Lizard Monster specific classes
    public LizardModel LizardMonsterModel;
    public LizardView LizardMonsterView;
    public LizardController LizardMonsterController;

    // Rabbit Monster specific classes
    public RabbitModel RabbitMonsterModel;
    public RabbitView RabbitMonsterView;
    public RabbitController RabbitMonsterController;

    // Cat Monster specific classes
    // Rabbit Monster specific classes
    public CatModel CatMonsterModel;
    public CatView CatMonsterView;
    public CatController CatMonsterController;

    // Initializing all monster controllers
    void Awake()
    {
        LizardMonsterController = new LizardController(LizardMonsterModel, LizardMonsterView);
        RabbitMonsterController = new RabbitController(RabbitMonsterModel, RabbitMonsterView);
        CatMonsterController = new CatController(CatMonsterModel, CatMonsterView);
    }
}
