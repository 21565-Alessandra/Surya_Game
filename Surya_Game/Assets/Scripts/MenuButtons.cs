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

     public void OnFourthLevelButton()
    {
        SceneManager.LoadScene(9);
    }

    public void OnPlayButton3()
    {
        SceneManager.LoadScene(12);
    }

    public void OnFifthLevelButton()
    {
        SceneManager.LoadScene(11);
    }



    // ABOUT MENUS 
    public void OnAboutButton()
    {
        SceneManager.LoadScene("About");
    }

     public void OnAboutButton2()
    {
        SceneManager.LoadScene("About2");
    }

    public void OnBackButton()
    {
        SceneManager.LoadScene(0);
    }




}

