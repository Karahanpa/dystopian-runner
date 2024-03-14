using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public GameObject[] medals;
    public static float score = 0;
    void Start()
    {
        UpdateScoreText();
    }

    private void FixedUpdate()
    {
        AddScore(1);
        UpdateScoreText();

        if (score >= 1000)
        {
            medals[0].SetActive(true);
        }
        else
        {
            medals[0].SetActive(false);
        }

        if (score >= 1200)
        {
            medals[0].SetActive(false);
        }

        if (score >= 1900)
        {
            medals[1].SetActive(true);
        }
        else
        {
            medals[1].SetActive(false);
        }

        if (score >= 2200)
        {
            medals[1].SetActive(false);
        }

        if (score >= 3000)
        {
            medals[2].SetActive(true);
        }
        else
        {
            medals[2].SetActive(false);
        }

        if (score >= 3300)
        {
            medals[2].SetActive(false);
        }

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
