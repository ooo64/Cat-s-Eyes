using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public int maxHealth = 3;

    public SpriteRenderer playerSr;
    public PlayerMovement playerMovement;
    public GameObject gameOverPanel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = maxHealth;

        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(false);
        }
    }


    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            if (playerSr != null)
            {
                playerSr.enabled = false;
            }
            if (playerMovement != null)
            {
                playerMovement.enabled = false;
            }
            if (gameOverPanel != null)
            {
                gameOverPanel.SetActive(true);
            }

            Time.timeScale = 0f;
        }
    }
   
}

