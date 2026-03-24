using UnityEngine;
using System;

public class PlayerStats : MonoBehaviour
{
    public PlayerStatsData baseStats;

    public float currentHealth;
    

    public float Speed { get; private set; }
    

    public event Action OnStatsChanged;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = baseStats.maxHealth;
        

        Speed = baseStats.speed;
        

        NotifyChange();
    }

    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, baseStats.maxHealth);

        Debug.Log("Player took damage: " + amount);

        NotifyChange();
    }

    public void Heal(float amount)
    {
        currentHealth += amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, baseStats.maxHealth);

        Debug.Log("Player Healed: " + amount);

        NotifyChange();
    }

    public void BoostSpeed(float amount)
    {
        Speed += amount;
        Speed = Mathf.Max(0, Speed);

        NotifyChange();
    }

    void NotifyChange()
    {
        OnStatsChanged?.Invoke();
    }
}
