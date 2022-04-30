using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour
{
    public Text scoreText;

    private int score;

   

    void Update()
    {
        scoreText.text = score.ToString();

        if(score>=10)
        {
            SceneManager.LoadScene(3);
        }
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "meteor")
            {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
            SoundManager.PlaySound ("meteorSound");       
    }

    void OnTriggerExit2D(Collider2D target)
    {
        if(target.tag == "skyObjects")
        {
            // SoundManager.PlaySound ("catch");
            Destroy(target.gameObject);
            score++;
        }
    }

    


}
