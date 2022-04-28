using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DestroyObjects2: MonoBehaviour
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
         
         if(ScoreNum>=32)
         {
            SceneManager.LoadScene(10);
         }

     }

}
