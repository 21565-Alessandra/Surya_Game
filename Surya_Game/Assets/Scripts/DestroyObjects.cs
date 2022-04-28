using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DestroyObjects: MonoBehaviour
{
     public Text MyScoreText;
     private int ScoreNum;

     void Start()
     {
         ScoreNum = 0;
         MyScoreText.text = "Score: " + ScoreNum;
     }

     

     private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "skyBlocks")
        {
            ScoreNum++;
            Destroy(collision.gameObject);
            MyScoreText.text = "Score: " + ScoreNum;
        }
    }

  void Update()
     {
         
         if(ScoreNum>=36)
         {
            SceneManager.LoadScene(8);
         }

     }

}
