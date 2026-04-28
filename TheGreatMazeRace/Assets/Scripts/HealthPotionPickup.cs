using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthPotionPickup : MonoBehaviour
{
    public int potionNumber = 1;

    [System.Obsolete]
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PotionManager scoreManager = FindObjectOfType<PotionManager>();
            if (scoreManager != null)
            {
                scoreManager.AddPotions(potionNumber);
            }
            DataManager.Instance.RecordItemCollected("Health Potion");
            Destroy(gameObject);
        }
    }

    
}
