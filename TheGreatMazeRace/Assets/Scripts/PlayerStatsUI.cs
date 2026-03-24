using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class PlayerStatsUI : MonoBehaviour
{
    public PlayerStats playerStats;

    public Image healthBar;
    

    private void Start()
    {
        playerStats.OnStatsChanged += UpdateUI;
        UpdateUI();
    }

    void UpdateUI()
    {
        healthBar.fillAmount = playerStats.currentHealth / playerStats.baseStats.maxHealth;
    }
}
