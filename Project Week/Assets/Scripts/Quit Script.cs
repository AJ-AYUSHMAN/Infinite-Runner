using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitScript : MonoBehaviour
{   
    public void Quitgame()
    {
        Application.Quit();
    }

    public void restartgame()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1f;
    }
}
