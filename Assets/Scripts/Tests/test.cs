using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class test : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Colliding");
    }
}
