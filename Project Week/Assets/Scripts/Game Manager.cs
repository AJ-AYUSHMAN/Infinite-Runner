using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool hasGameEnded = false;
    public GameObject restartPanel;
    public GameObject pausePanel;
   public void EndGame()
    {
        if (hasGameEnded == false)
        {
            hasGameEnded = true;
            Invoke("RestartGame", 0.5f);
        }
    }

    void RestartGame()
    {
        restartPanel.SetActive(true);
        pausePanel.SetActive(false);
        Time.timeScale = 0f;
    }
}
