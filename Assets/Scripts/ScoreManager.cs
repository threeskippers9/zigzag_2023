using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;

    public int score = 0;

    public void UpdateScore()
    {
        score += 1;
        scoreText.text = "Score: " + score;
    }

    public void EndGame()
    {
        FindObjectOfType<EndGameUI>().ShowScores(score);
    }
}
