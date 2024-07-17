using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public Text highScoreText;


    int currentScore;
    int highScore;
    void Start()
    {
       highScore = PlayerPrefs.GetInt("highscore", 0);
       highScoreText.text = "HighScore: " + highScore.ToString() + "m";
    }
    private void Update()
    {
        currentScore = Mathf.FloorToInt(player.position.z);
        scoreText.text = currentScore.ToString() + "m";
        if (currentScore > highScore)
        {
            highScore = currentScore;
            highScoreText.text = "New HighScore: " + highScore.ToString();
            PlayerPrefs.SetInt("highscore", currentScore);
        }
    }
}
