using UnityEngine;
using UnityEngine.EventSystems;

public class LizardView : AbstractMonsterView, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("clicking");
    }
}
