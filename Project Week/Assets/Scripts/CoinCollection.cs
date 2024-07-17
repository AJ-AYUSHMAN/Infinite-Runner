using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollection : MonoBehaviour
{
    public Text currentCoinText; // Reference to the Text component for the current coin count
    public Text totalCoinText; // Reference to the Text component for the total coin count

    private int currentCoinCount = 0;
    private int totalCoinCount;

    void Start()
    {
        // Retrieve the total coins collected from PlayerPrefs
        totalCoinCount = PlayerPrefs.GetInt("TotalCoins", 0);
        totalCoinText.text = "Total Coins: " + totalCoinCount.ToString();

        // Update the current coin count UI
        currentCoinText.text = "Coins: " + currentCoinCount.ToString();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            currentCoinCount++;
            totalCoinCount++;
            PlayerPrefs.SetInt("TotalCoins", totalCoinCount);
            Destroy(other.gameObject);

            // Update the current coin count UI
            currentCoinText.text = "Coins: " + currentCoinCount.ToString();

            // Update the total coin count UI
            totalCoinText.text = "Total Coins: " + totalCoinCount.ToString();

            Debug.Log("Current Coins: " + currentCoinCount);
            Debug.Log("Total Coins: " + totalCoinCount);
        }
    }
}


