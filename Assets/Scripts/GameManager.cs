using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Button startBtn;
    public Button optionsBtn;
    public Button quitBtn;

    #region Singleton
    public static GameManager instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("GameManager has more tha one instance");
            return;
        }

        instance = this;
    }
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        startBtn.onClick.AddListener(() => StartGame());
    }

    void StartGame()
    {
        SceneManager.LoadScene("FirstLevel");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
