using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;
    public GameObject losePanel;
    private int score = 0;
    public float timeRemaining = 30f;

    void Update()
    {
        timeRemaining -= Time.deltaTime;
        timerText.text = "Temps : " + Mathf.Ceil(timeRemaining);

        if (timeRemaining <= 0)
        {
            Time.timeScale = 0f;
            losePanel.SetActive(true);
        }
    }

    public void AddScore(int amount)
    {
        score += amount;
        scoreText.text = "Score : " + score;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}