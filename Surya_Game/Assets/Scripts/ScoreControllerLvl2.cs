using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreControllerLvl2 : MonoBehaviour
{
    public Text scoreText;

    private int score;

   

    void Update()
    {
        scoreText.text = score.ToString();

        if(score>=10)
        {
            SceneManager.LoadScene(5);
        }
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "meteor")
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void OnTriggerExit2D(Collider2D target)
    {
        if(target.tag == "skyObjects")
        {
            Destroy(target.gameObject);
            score++;
        }
    }

    


}
