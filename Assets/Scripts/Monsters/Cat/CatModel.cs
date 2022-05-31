using UnityEngine;

public class CatModel : AbstractMonsterModel
{
    public Dialogue dialogueForKey;
    public Dialogue dialogueForFreeCat;
    public Item key;
    public GameObject cage;
    public GameObject chestItem;

    private void Awake()
    {
        MonsterName = "Cat";
    }
}
