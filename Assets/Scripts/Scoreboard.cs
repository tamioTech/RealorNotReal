using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scoreboard : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] int maxTime = 10;
    [SerializeField] float gameSpeed = .1f;

    int timeLeft;
    // Start is called before the first frame update
    void Start()
    {
        timeLeft = maxTime;
        timerText.text = timeLeft.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        float timer = Mathf.Round(Time.time);
        print(timer);
        //timeLeft -= (Mathf.RoundToInt((Time.deltaTime * gameSpeed));
        if (timer < 10)
        {
            timerText.text = "0" + timer.ToString();
        }
        else
        {
            timerText.text = timer.ToString();
        }
    }
}
