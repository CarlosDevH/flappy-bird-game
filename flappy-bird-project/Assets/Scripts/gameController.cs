using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameController : MonoBehaviour
{
    public int Score;
    public Text scoreText;
    //Starts when starting the game
    void Start()
    {
        Time.timeScale = 1; 
    }
    //Restart the Game on Collision
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
