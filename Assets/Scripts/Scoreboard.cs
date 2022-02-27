using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scoreboard : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] TextMeshProUGUI levelText;
    [SerializeField] public int level = 0;
    [SerializeField] float gameSpeed = 1f;

    float timer;
    float startTimerTime;
    float currentTime;
    public int score = 0;

    
    
    void Start()
    {
        timer = 0;
        score = 0;
        level = 0;
        UpdateTimerText();
        UpdateScoreText();
        UpdateLevelText();
        startTimerTime = Time.time;
    }


    void Update()
    {
        UpdateTimerText();
    }

    private void UpdateTimerText()
    {
        currentTime = Time.time - startTimerTime;
        timer = Mathf.Round(currentTime * gameSpeed) ;
        
        if (timer > 59)
        {
            timer = 0;
            startTimerTime = Time.time;
            
            level++;
            print("PLUS A LEVEL");
            print("spawnTime: " + FindObjectOfType<Respawn>().spawnTime);
            FindObjectOfType<Respawn>().spawnTime -= 0.6f;
            UpdateLevelText();
        }
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
        print("currentLevel = " + level);
        if(level>7)
        {

            FindObjectOfType<GameMusic>().UpdateFinalScore();

            timer = 0;
            level = 0;
            FindObjectOfType<Respawn>().spawnTime = 5f;
            FindObjectOfType<SceneLoader>().LoadGameOverScreen();

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

    public void RestartLevel()
    {

    }
}
