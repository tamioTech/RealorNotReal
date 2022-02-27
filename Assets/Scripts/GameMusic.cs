using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMusic : MonoBehaviour
{
    public int finalScore;

    private void Awake()
    {
        if (!GetComponent<AudioSource>().isPlaying)
        {
            GetComponent<AudioSource>().Play();
        }
        DontDestroyOnLoad(gameObject);
    }

    public void UpdateFinalScore()
    {
        finalScore = FindObjectOfType<Scoreboard>().score;
        print("finalScore: " + finalScore);
    }
}
