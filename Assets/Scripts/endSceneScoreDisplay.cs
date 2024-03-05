using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class endSceneScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    void Start()
    {
        scoreText.text = "Your score was: " + ScoreManager.score.ToString();
    }
}
