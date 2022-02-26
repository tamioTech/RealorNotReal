using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scoreboard : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] TextMeshProUGUI levelText;
    [SerializeField] int level = 0;

    float timer;
    int score = 0;

    void Start()
    {
        timer = 0;
        UpdateTimerText();
        UpdateScoreText();
        UpdateLevelText();
    }


    void Update()
    {
        UpdateTimerText();
    }

    private void UpdateTimerText()
    {
        timer = Mathf.Round(Time.time);
        if (timer < 10)
        {
            timerText.text = ":0" + timer.ToString();
        }
        else
        {
            timerText.text = ":" + timer.ToString();
        }
    }

    private void UpdateLevelText()
    {
        if (level < 10)
        {
            levelText.text = "0" + level.ToString();
        }
        else
        {
            levelText.text = level.ToString();
        }
    }

    private void UpdateScoreText()
    {
        scoreText.text = "$" + score.ToString();
    }

    public void AddToScore(int amount)
    {
        score += amount;
        UpdateScoreText();
    }
}
