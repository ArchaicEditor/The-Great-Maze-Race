using TMPro;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStatsUI : MonoBehaviour
{
    public PlayerStats playerStats;

    public Image healthBar;

    //public GameObject Player;

    public GameObject GameOverScreen;

    public GameManager gameManager;

    
    

    private void Start()
    {
        playerStats.OnStatsChanged += UpdateUI;
        UpdateUI();
    }

    void UpdateUI()
    {
        healthBar.fillAmount = playerStats.currentHealth / playerStats.baseStats.maxHealth;
    }

    private void Update()
    {
        if (playerStats.currentHealth <= 0)
        {
            //Player.SetActive(false);
            GameOverScreen.SetActive(true);
            gameManager.gameActive = false;
        }
    }

}
