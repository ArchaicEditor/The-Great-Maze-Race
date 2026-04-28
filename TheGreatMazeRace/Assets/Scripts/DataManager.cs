using UnityEngine;
using System;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;

    private float sessionStartTime;
    private int deathCount = 0;
    private int itemsCollected = 0;

    void Awake()
    {
        // Singleton pattern
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        StartSession();
    }

    void OnApplicationQuit()
    {
        EndSession();
    }

    // --- Session Tracking ---
    void StartSession()
    {
        sessionStartTime = Time.time;
        Debug.Log("Session started");
    }

    void EndSession()
    {
        float sessionDuration = Time.time - sessionStartTime;
        Debug.Log("Session ended. Duration: " + sessionDuration);
    }

    // --- Death Tracking ---
    public void RecordDeath()
    {
        deathCount++;
        Debug.Log("Deaths: " + deathCount);
    }

    // --- Item Tracking ---
    public void RecordItemCollected(string itemName)
    {
        itemsCollected++;
        Debug.Log("Collected: " + itemName + " | Total: " + itemsCollected);
    }
}