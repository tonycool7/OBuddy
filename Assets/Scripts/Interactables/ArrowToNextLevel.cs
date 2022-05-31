using UnityEngine;
using UnityEngine.SceneManagement;

public class ArrowToNextLevel : MonoBehaviour
{
    string playerTag = "Player";

    private void OnTriggerEnter2D(Collision2D collision)
    {
        print("here");
        if (collision.gameObject.CompareTag(playerTag))
        {
            print("mobing");
            SceneManager.LoadScene("OBuddyScene");
        }
    }
}
