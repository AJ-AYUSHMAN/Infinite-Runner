using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.collider.tag == "Obstacles")
        {
            Debug.Log("Collided");
            FindObjectOfType<GameManager>().EndGame();
        }
    }   
}
