using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractMonsterController : IMonstersController
{
    private IMonstersModel Model;
    private DialogueManager dialogueManager;

    public AbstractMonsterController(IMonstersModel IModel)
    {
        Model = IModel;
//        dialogueManager = new DialogueManager(Model.MonsterDialogues);
  //      dialogueManager.PrepareDialogues();
    }

/*    public string FetchMonsterDialogue()
    {
        return dialogueManager.GetNextDialogue();
    }*/

    public void MonsterHitByRay()
    {
        Debug.Log($"{Model.MonsterName} has been Hit");
        Model.MonsterHealth = -10;
        Debug.Log($"{Model.MonsterName}'s current health is {Model.MonsterHealth}");
    }

}
