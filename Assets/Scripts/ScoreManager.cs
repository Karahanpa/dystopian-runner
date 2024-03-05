using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public static float score = 0;
    void Start()
    {
        UpdateScoreText();
    }

    private void FixedUpdate()
    {
        AddScore(1);
        UpdateScoreText();
    }
    public void AddScore(float amount)
    {
        score += amount;
        UpdateScoreText();
    }
    void UpdateScoreText()
    {
        int integerScore = Mathf.FloorToInt(score);
        string displayScore = integerScore.ToString();
        scoreText.text = "Score: " + displayScore;
    }
    
    public static void ResetScore()
    {
        score = 0;
    }
}
