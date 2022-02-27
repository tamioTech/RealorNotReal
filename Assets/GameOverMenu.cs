using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverMenu : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI finalScoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        finalScoreText.text = "$"+FindObjectOfType<GameMusic>().finalScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
