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
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        timerText.text = ":" + timer.ToString();
        levelText.text = ":00";
        scoreText.text = "$0";
    }

    // Update is called once per frame
    void Update()
    {
        timer = Mathf.Round(Time.time);
        UpdateScoreboard();
    }

    private void UpdateScoreboard()
    {
        if (timer < 10)
        {
            timerText.text = ":0" + timer.ToString();
        }
        else
        {
            timerText.text = ":" + timer.ToString();
        }
        if (level < 10)
        {
            levelText.text = "0" + level.ToString();
        }
        else
        {
            levelText.text = level.ToString();
        }
        
    }
}
