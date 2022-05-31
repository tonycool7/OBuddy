using UnityEngine;
using UnityEngine.SceneManagement;

public class ArrowToNextLevel : MonoBehaviour
{
    string playerTag = "Player";
    GameManager gameManager;

    private void Start()
    {
        gameManager = GameManager.instance;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(playerTag))
        {
            gameManager.GoToLevel3();
        }
    }
}
