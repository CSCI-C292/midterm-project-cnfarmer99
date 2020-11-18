using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuSystem : MonoBehaviour
{
    public void playClicked()
    {
        SceneManager.LoadScene("LevelOne");
    }

    public void instructionsClicked()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void quitClicked()
    {
        Application.Quit();
    }

    public void backClicked()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Update()
    {
        if(SceneManager.GetActiveScene().name == "LevelOne")
        {
            if(Input.GetKeyDown(KeyCode.Escape)) 
            {
                Debug.Log("pressed");
                SceneManager.LoadScene("LevelTwo");
            }
        }
        if(SceneManager.GetActiveScene().name == "LevelTwo")
        {
            if(Input.GetKeyDown(KeyCode.Escape)) 
            {
                Debug.Log("pressed");
                SceneManager.LoadScene("PlayAgain");
            }
        }
    }
}
