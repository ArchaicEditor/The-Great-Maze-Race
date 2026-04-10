using UnityEngine;
using System.IO;

public class SaveSystem : MonoBehaviour
{
    public static SaveSystem Instance;

    private string savePath;

    private void Awake()
    {
        // Singleton pattern
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        savePath = Application.persistentDataPath + "/save.json";
    }

    public void SavePlayer(Vector2 position)
    {
        PlayerData data = new PlayerData();
        data.posX = position.x;
        data.posY = position.y;
        

        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(savePath, json);
        Debug.Log("Game Saved at: " + savePath);
    }

    public PlayerData LoadPlayer()
    {
        if (File.Exists(savePath))
        {
            string json = File.ReadAllText(savePath);
            PlayerData data = JsonUtility.FromJson<PlayerData>(json);
            Debug.Log("Game Loaded");
            return data;
        }
        else
        {
            Debug.LogWarning("No save file found.");
            return null;
        }
    }
}
