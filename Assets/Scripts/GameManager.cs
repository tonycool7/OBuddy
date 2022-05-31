using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Button startBtn;
    public Button optionsBtn;
    public Button quitBtn;
    public TextMeshProUGUI feedbackText;
    public GameObject arrrowToNextLevel;
    public Item expectedItem;
    public bool levelOne = true; // for handcuff + monster Interactions

    bool hasGivenRabbitChest = false;
    bool freedCatState = false;
    bool hasPickedItem = false;
    bool addedLevel3Item = false;
    bool _goToHappyEnding = false;
    bool _goToBadEnding = false;
    float maxTimer = 4f;
    float currentTime = 0f;
    Inventory inventory;

    public bool goToHappyEnding { get { return _goToHappyEnding; } set { _goToHappyEnding = value; } }
    public bool goToBadEnding { get { return _goToBadEnding; } set { _goToBadEnding = value; } }

    bool conditionToMoveToLevel2 => hasGivenRabbitChest && freedCatState && hasPickedItem;

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
        inventory = Inventory.instance;
        if (startBtn != null) startBtn.onClick.AddListener(() => StartGame());
    }

    private void Update()
    {
        if (currentTime > 0f)
        {
            currentTime -= Time.deltaTime;
            if (currentTime <= 0.5) ClearFeedbackText();
        }

        if (SceneManager.GetActiveScene().name == "ThirdLevel" && !addedLevel3Item)
        {
            inventory.Add(expectedItem);
            addedLevel3Item = true;
        }

        if (conditionToMoveToLevel2) DisplayArrowToNextLevel();
    }

    public void SetCatFreeState(bool state)
    {
        freedCatState = state;
    }

    public void SetHasGivenRabbitChest(bool state)
    {
        hasGivenRabbitChest = state;
    }

    public void SetHasPickedItem(bool state)
    {
        hasPickedItem = state;
    }

    void ClearFeedbackText()
    {
        feedbackText.text = "";
    }

    void StartGame()
    {
        SceneManager.LoadScene("FirstLevel");
    }

    public void DisplayArrowToNextLevel()
    {
        arrrowToNextLevel.gameObject.SetActive(true);
    }

    public void GoToLevel3()
    {
        SceneManager.LoadScene("ThirdLevel");
    }

    public void GoToBadEndingLevel()
    {
        SceneManager.LoadScene("BadEndScene");
    }

    public void GoToHappyEndingLevel()
    {
        SceneManager.LoadScene("HappyEndScene");
    }

    public void GoToLevel2()
    {
        SceneManager.LoadScene("OBuddyScene");
    }

    public void UpdateFeedBack(string text)
    {
        currentTime = maxTimer;
        StopAllCoroutines();
        StartCoroutine(TypeSentence(text));
    }

    IEnumerator TypeSentence(string sentence)
    {
        feedbackText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            feedbackText.text += letter;
            yield return null;
        }
    }
}
