using UnityEngine;

public class CatModel : AbstractMonsterModel
{
    public Dialogue dialogueForKey;
    public Item key;
    public GameObject cage;

    private void Awake()
    {
        MonsterName = "Cat";
    }
}
