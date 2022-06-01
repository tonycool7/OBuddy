using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractProtagonistController : MonoBehaviour, IProtaginistController
{
    public Transform modelObj;

    protected IProtaginistModel model;

    private void Start()
    {
        model = modelObj.GetComponent<IProtaginistModel>();
    }

    public AbstractProtagonistController(IProtaginistModel SpecificModel)
    {
        model = SpecificModel;
    }

    public void PointAndMove()
    {
        Vector3 screenMouseClick = Input.mousePosition;
        Vector2 worldClickPostion = Camera.main.ScreenToWorldPoint(screenMouseClick);

        RaycastHit2D hit = Physics2D.Raycast(worldClickPostion, Vector2.zero);

        if (hit)
        {
            switch (hit.collider.tag)
            {
                case "Floor":
                    model.currentPosition = hit.point;
                    break;
                case "Monster":
                    IMonstersView monster = hit.collider.GetComponent<IMonstersView>();
                    if (monster != null) monster.MonsterHitByRay();
                    model.currentPosition = hit.point;
                    break;
                default:
                    break;
            }
        }
    }
}
