using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intropanel : MonoBehaviour
{
    public GameObject instructionPanel;
    public GameObject startPanel;
   

    public void ToogleInstructionPanel(int toogle)
    {
        if (toogle == 1)
        {
            instructionPanel.SetActive(false);
            startPanel.SetActive(true);
        }
        else
        {
            instructionPanel.SetActive(true);
            startPanel.SetActive(false);
        }
    }

    
}
