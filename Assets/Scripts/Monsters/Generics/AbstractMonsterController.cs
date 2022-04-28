using UnityEngine;

public class AbstractMonsterController : IMonstersController
{
    private IMonstersModel model;
    DialogueManager dialogueManager;

    public AbstractMonsterController(IMonstersModel IModel)
    {
        model = IModel;
    }

    public void MonsterSpeaking()
    {
        dialogueManager = DialogueManager.instance;
        dialogueManager.StartDialogue(model.MonsterDialogue);
    }

    public void MonsterHitByRay()
    {
        Debug.Log($"{model.MonsterName} has been Hit");
        model.MonsterHealth = -10;
        Debug.Log($"{model.MonsterName}'s current health is {model.MonsterHealth}");
    }

}
