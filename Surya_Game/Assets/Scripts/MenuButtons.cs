using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public void OnStartButton()
    {
        SceneManager.LoadScene(1);
    }

    public void OnPlayButton()
    {
        SceneManager.LoadScene(2);
    }

     public void OnQuitButton()
    {
        Application.Quit();
    }

    public void OnSecondLevelButton()
    {
        SceneManager.LoadScene(4);
    }

    public void OnThirdLevelButton()
    {
        SceneManager.LoadScene(6);
    }

    public void OnPlayButton2()
    {
        SceneManager.LoadScene(7);
    }

}

