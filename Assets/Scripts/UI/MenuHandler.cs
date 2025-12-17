using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{
    public TMP_InputField playerNameInputField;
    public TextMeshProUGUI ScoreDisplayText;
    private void Start()
    {
        // 1. Load and display the Best Score immediately
        DisplayBestScore();

        // 2. Optional: Set the input field placeholder to the previous high score name
        SetInputFieldPlaceholder();
    }

    private void DisplayBestScore()
    {
        if (DataManager.Instance != null && ScoreDisplayText != null)
        {
            // Get the data that was loaded by the DataManager's Awake() method
            string name = DataManager.Instance.highscoreData.highScoreName;
            int score = DataManager.Instance.highscoreData.highScore;

            // Display the best score and the name of the high scorer
            ScoreDisplayText.text = $"Best Score: {name}: {score}";
        }
    }
    private void SetInputFieldPlaceholder()
    {
        if (DataManager.Instance != null && playerNameInputField != null)
        {
            // Get the current high score name
            string name = DataManager.Instance.highscoreData.highScoreName;

            // Get the actual TMP_Text component used for the placeholder
            TMP_Text placeholderText = playerNameInputField.placeholder.GetComponent<TMP_Text>();

            if (placeholderText != null)
            {
                // Set the placeholder text to suggest the previous high scorer's name
                placeholderText.text = $"{name} (Previous Champion)";
            }
        }
    }

    // This method will be called when the button is clicked
    public void StartGame()
    {
        string name = playerNameInputField.text;

        if (!string.IsNullOrEmpty(name))
        {
            DataManager.Instance.currentSessionPlayerName = name;
            SceneManager.LoadScene(1);
        }
        else
        {
            Debug.Log("Please enter a name first!");
        }
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitting the game...");
    }
}
