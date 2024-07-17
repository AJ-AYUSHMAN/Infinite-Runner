using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{
    public GameObject startPanel;
    public GameObject mapPanel;
    public void OnToogleStartPanel(int toogle) 
    { 
        if (toogle == 1)
        {
            mapPanel.SetActive(false);
            startPanel.SetActive(true);
        }
        else
        {
            mapPanel.SetActive(true);
            startPanel.SetActive(false);
        }
    }
 }
