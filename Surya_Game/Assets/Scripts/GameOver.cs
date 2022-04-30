using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "danger")
        {
            Debug.Log("GAME OVER");
            SceneManager.LoadScene("Game_Over");
        }
    }
    
        
}
