using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreDisplay : MonoBehaviour
{
    public Text highScoreText;
    public Text totalCoinsText;
    public GameObject highScorePanel;
    public GameObject startPanel;

    void Start()
    {
        // Load the high score from PlayerPrefs
        int highScore = PlayerPrefs.GetInt("highscore", 0);
        // Display the high score
        highScoreText.text = "High Score: " + highScore.ToString();

        //load the total coin collected from playerprefs
        int totalCoins = PlayerPrefs.GetInt("TotalCoins", 0);
        //display the total coins
        totalCoinsText.text = "Total Coins: " + totalCoins.ToString();
    }

    public void OnToogleStartPanel(int toogle)
    {
        if (toogle == 1)
        {
            highScorePanel.SetActive(false);
            startPanel.SetActive(true);
        }
        else
        {
            highScorePanel.SetActive(true);
            startPanel.SetActive(false);
        }
    }
}
