using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public float gameTime;

    public bool gameActive;

    void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        gameActive = true;
    }
    void Update()
    {
        if (gameActive)
        { 
            gameTime += Time.deltaTime;
            UIController.Instance.UpdateTimer(gameTime);
        }
        

    }
}
