using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private void Update()
    {
        if(SceneManager.GetActiveScene().buildIndex == 1)
        {
            FindObjectOfType<Respawn>().gameStarted = true;
        }
        else
        {
            FindObjectOfType<Respawn>().gameStarted = false ;
        }
    }

    public void StartButton()
    {
        SceneManager.LoadScene(1);
    }

    public void TryAgainButton()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadGameOverScreen()
    {
        SceneManager.LoadScene(2);

    }

     
}
